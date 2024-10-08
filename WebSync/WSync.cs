﻿/*
    NATURASOFT\szamlatetel.FEJID == NATURASOFT\szamla.ID
*/
using Database;
using Datum;
using System;
using System.Data;
using System.Windows.Forms;
using Configuration;
using System.Threading.Tasks;

namespace WebSync
{
    public class WSync
    {

        private MySQL mysql;
        private MSSQL mssql;
        private LocalDate ld;
        private Cfg cfg;
        
        #region Szinkronizálás Webáruház -> Számlázó
        public string Run(NotifyIcon notif)
        {
            int rq = 0;
            string retString;
            try
            {
                mysql = new MySQL();
                mysql.DBConnect();
                mssql = new MSSQL();
                cfg = new Cfg();
                ld = new LocalDate();
                string syncStart = ld.getLocalTime();
                string q = "SELECT ot.virtuemart_order_id as orderid, ot.order_number as ident, ot.order_total as brutto, ot.order_salesPrice as netto, ot.order_billTaxAmount as afa, " +
                    "ot.virtuemart_paymentmethod_id as payID, ut.last_name as keresztnev, ut.first_name as vezeteknev, ut.address_1 as cim, ut.address_2 as cim2, ut.city as varos, ut.zip as irsz FROM " +
                    "qz3vf_virtuemart_orders as ot LEFT JOIN qz3vf_virtuemart_order_userinfos as ut ON(ut.virtuemart_order_id = ot.virtuemart_order_id) WHERE ot.synced = 0 AND type = 'BT'";
                DataTable get = mysql.QSelect(q);
                int rowsCount = get.Rows.Count;
                rq = rowsCount;
                for (int i = 0; i <= rowsCount - 1; i++)
                {
                    string orderID = get.Rows[i]["orderid"].ToString();
                    //Számlatörzs beszúrása
                    string szamla_fields = this.getSzamlaFields();
                    string szamla_vals = this.getSzamlaValues(get.Rows[i]);
                    mssql.Insert("SZAMLA", szamla_fields, szamla_vals);
                    int lastID = mssql.LastIndex("SZAMLA");
                    //Ügyfél feltöltése
                    //this.insertUser(get, i);
                    //Számlatételek lehívása
                    string fields = "order_item_name, order_item_sku, product_quantity, product_priceWithoutTax, product_basePriceWithTax, product_tax";
                    string iq = "SELECT " + fields + " FROM `qz3vf_virtuemart_order_items` WHERE virtuemart_order_id = " + orderID + "";
                    DataTable items = mysql.QSelect(iq);

                    int itemCount = items.Rows.Count;
                    for (int j = 0; j <= itemCount - 1; j++)
                    {
                        DataRow item = items.Rows[j];
                        string item_fields = this.getTetelFields();
                        string item_values = this.getTetelValue(lastID.ToString(), item);
                        mssql.Insert("SZAMLATETEL", item_fields, item_values);
                    }
                    mysql.Update("qz3vf_virtuemart_orders", "synced = 1", "WHERE virtuemart_order_id = " + orderID + "");
                }

                retString = syncStart + " > Szinkronizálva " + rowsCount.ToString() + " db megrendelés!";
                notif.BalloonTipIcon = ToolTipIcon.Info;

            }
            catch(Exception ex)
            {
                notif.BalloonTipIcon = ToolTipIcon.Error;
                retString = ex.Message;
            }
            if (rq > 0)
            {
                notif.BalloonTipText = retString;
                notif.ShowBalloonTip(1000);
            };
            return retString;
        }
        #endregion

        #region user update
        private void insertUser(DataTable get, int i)
        {
            DataRow item = get.Rows[0];
            string szlaname = item["vezeteknev"].ToString() + " " + item["keresztnev"].ToString();
            string szlairsz = item["irsz"].ToString();
            string szlavaros = item["varos"].ToString();
            string szlacim = item["cim"].ToString();

            string q = "SELECT ot.virtuemart_order_id as orderid, ot.order_number as ident, ot.order_total as brutto, ot.order_salesPrice as netto, ot.order_billTaxAmount as afa, " +
                "ot.virtuemart_paymentmethod_id as payID, ut.last_name as keresztnev, ut.first_name as vezeteknev, ut.address_1 as cim, ut.address_2 as cim2, ut.city as varos, " +
                "ut.zip as irsz, ut.address_type as type FROM qz3vf_virtuemart_orders as ot LEFT JOIN qz3vf_virtuemart_order_userinfos as ut ON(ut.virtuemart_order_id = ot.virtuemart_order_id) " +
                "WHERE ot.virtuemart_order_id = " + item["orderid"] + " AND ot.type = 'ST'";
            int have = mysql.QCount(q);
            if(have == 1)
            {
                DataTable _post = mysql.QSelect(q);
                DataRow post = _post.Rows[0];
                string postnev = post["vezeteknev"].ToString() + " " + post["keresztnev"].ToString();
                string postirsz = post["irsz"].ToString();
                string postvaros = post["varos"].ToString();
                string postcim = post["cim"].ToString();
            }
            else
            {
                string postnev = szlaname;
                string postirsz = szlairsz;
                string postvaros = szlavaros;
                string postcim = szlacim;
            }

            /**
             *  Címkezelés menete:
             *  Ha nincs név, akkor felviszi az adatokat
             *  Ha van név, de nem egyezik az irányítószám, akkor felviszi az adatokat
             *  Ha van név, egyezik az irsz, de más az utca, akkor feltölt
             *  Ha van név, egyezik az irsz + az utca* akkor feltölt
             *  Egyébként kikeresi a NATURA_ID-t.
             *  
             *  *= Utca, házszám formálása az alábbi formára:
             *  Béke út 34. ==> békeu34 (mindent kisbetűvel; szóközök nélkül
             *  valamint az út, utca, u cseréje, hogy simán "u" legyen és ha van a végén pont, azt is eltávolítjuk
             *  Ezáltal elkerülhető, hogy ugyan azon személy, ugyanazzal a címmel többször szerepeljen az ügyféltörzsben,
             *  egyszerű elgépelések miatt.
             * **/

        }
        #endregion

        #region számlatörzs
        private string getSzamlaFields()
        {
            //fields.length = 38
            string fields = "SZAMLASZAM," +
                "SZAMLAEV," +
                "SZAMLASORSZAM," +
                "KIALLITONEV," +
                "KIALLITOADATOK," +
                "UGYFELID," +
                "UGYFELNEV," +
                "UGYFELADATOK," +
                "FIZMODKOD," +
                "FIZMODNYOMT," +

                "KELT," +
                "TELJESITES," +
                "ESEDEKESSEG," +
                "KIEGYENLITES," +
                "NETTO," +
                "AFA," +
                "BRUTTO," +
                "FIZETENDO," +
                "KIEGYENLITVE," +
                "FELSOMEGJEGYZES," +
                
                "ALSOMEGJEGYZES," +
                "PELDANYSZAM," +
                "HIVATKOZASISZAM," +
                "HIVATKOZASJELZO," +
                "BUILDNO," +
                "TIZEDESBEALLITASOK," +
                "LOGOID," +
                "NYELVELSO," +
                "NYELVMASOD," +
                "DEVIZANEM," +

                "ARFOLYAM," +
                "CSOPORT1," +
                "TIPUSINFO," +
                "FELHASZNALONEV," +
                "SZALLITOKESZULT," +
                "EGYEBINFO," +
                "FIZETVEPECSET," +
                "NAVSTATUS";
            return fields;
        }
        private string getSzamlaValues(DataRow row)
        {
            string payment;
            string payID;
            switch (row["payID"])
            {
                case "1": default: payment = "Utánvét"; payID = "3"; break;
                case "2": payment = "Átutalás"; payID = "2"; break;
                case "3": payment = "Bankkártya"; payID = "4"; break;
            }
            
            string vals = "'FELRE_" + row["ident"] + "'," +
                "" + ld.getLocalYear().Replace(".",string.Empty) + "," +
                "0," +
                "'" + cfg.getCfg("cegnev") + "'," +
                "'" + cfg.getCfg("cegcim") + "\r\nAdószám:" + cfg.getCfg("adoszam") + "'," +
                "0," +
                "'" + row["vezeteknev"] + " " + row["keresztnev"] + "'," +
                "'" + row["irsz"] + " " + row["varos"] + ", " + row["cim"] + " " + row["cim2"] + "'," +
                "" + payID + "," +
                "'" + payment + "'," +

                "'" + ld.getSqlDateTime() + "'," +
                "'" + ld.getSqlDateTime() + "'," +
                "'" + ld.getSqlDateTime() + "'," +
                "''," +
                "" + row["netto"].ToString().Replace(',','.') + "," +
                "" + row["afa"].ToString().Replace(',', '.') + "," +
                "" + row["brutto"].ToString().Replace(',', '.') + "," +
                "" + row["brutto"].ToString().Replace(',', '.') + "," +
                "0," +
                "'Webáruház által automatikusan generált számla!'," +
                
                "''," +
                "0," +
                "'" + ld.getLocalYear().Replace(".",string.Empty) + "/'," +
                "''," +
                "0," +
                "2000," +
                "0," +
                "1," +
                "1," +
                "'Ft'," +
                
                "1," +
                "0," +
                "'F'," +
                "''," +
                "''," +
                "''," +
                "''," +
                "''";
            return vals;
        }
        #endregion

        #region Számlatételek
        private string getTetelFields()
        {
            string tetel = "FEJID," +
                "TERMEKID," +
                "TERMEKNEV," +
                "TERMEKNEVNYOMT," +
                "TERMEKKOD," +
                "VTSZ," +
                "MEE," +
                "MENNYISEG," +
                "EGYSEGARNETTO," +
                "EGYSEGARBRUTTO," +
                "NETTO," +
                "AFA," +
                "BRUTTO," +
                "ORIGEGYSEGARNETTO," +
                "ORIGEGYSEGARBRUTTO," +
                "AFAKOD," +
                "MEGJEGYZES," +
                "KEDVEZMENY," +
                "ARKATEGID";

            return tetel;
        }
        private string getTetelValue(string szamlaID, DataRow item) {
            decimal netto = decimal.Parse(item["product_priceWithoutTax"].ToString());
            decimal brutto = decimal.Parse(item["product_basePriceWithTax"].ToString());
            decimal fullNetto = netto * (int)item["product_quantity"];
            decimal fullBrutto = brutto * (int)item["product_quantity"];
            string value = "" + szamlaID + "," +
                "0," +
                "'" + item["order_item_name"] + "'," +
                "''," +
                "'" + item["order_item_sku"] + "'," +
                "''," +
                "'db'," +
                "" + double.Parse(item["product_quantity"].ToString()) + "," +
                "" + netto.ToString().Replace(',','.') + "," +
                "" + brutto.ToString().Replace(',', '.') + "," +
                "" + fullNetto.ToString().Replace(',', '.') + "," +
                "" + item["product_tax"].ToString().Replace(',', '.') + "," +
                "" + fullBrutto.ToString().Replace(',', '.') + "," +
                "" + netto.ToString().Replace(',', '.') + "," +
                "" + brutto.ToString().Replace(',', '.') + "," +
                "1," +
                "''," +
                "0.0," +
                "1";
            return value;
        }
        #endregion


    }
}
