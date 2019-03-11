/*
    NATURASOFT\szamlatetel.FEJID == NATURASOFT\szamla.ID
*/
using Database;
using Datum;
using System;
using System.Data;
using System.Windows.Forms;

namespace WebSync
{
    public class WSync
    {

        private MySQL mysql;
        private MSSQL mssql;
        private LocalDate ld;

        #region Szinkronizálás Webáruház -> Számlázó
        public string Run(NotifyIcon notif)
        {
            string retString;
            try
            {
                mysql = new MySQL();
                mysql.DBConnect();
                mssql = new MSSQL();
                ld = new LocalDate();
                string syncStart = ld.getLocalTime();
                string q = "SELECT ot.virtuemart_order_id as orderid, ot.order_number as ident, ot.order_total as brutto, ot.order_salesPrice as netto, ot.order_billTaxAmount as afa, " +
                    "ut.last_name as keresztnev, ut.first_name as vezeteknev, ut.address_1 as cim, ut.address_2 as cim2, ut.city as varos, ut.zip as irsz FROM " +
                    "qz3vf_virtuemart_orders as ot LEFT JOIN qz3vf_virtuemart_order_userinfos as ut ON(ut.virtuemart_order_id = ot.virtuemart_order_id) WHERE ot.synced = 0";
                DataTable get = mysql.QSelect(q);
                int rowsCount = get.Rows.Count;
                for (int i = 0; i <= rowsCount - 1; i++)
                {
                    string orderID = get.Rows[i]["orderid"].ToString();
                    //Számlatörzs beszúrása
                    string szamla_fields = this.getSzamlaFields();
                    string szamla_vals = this.getSzamlaValues(get.Rows[i]);
                    mssql.Insert("SZAMLA", szamla_fields, szamla_vals);
                    int lastID = mssql.LastIndex("SZAMLA");
                    //Számlatételek lehívása
                    string fields = "order_item_name, product_quantity, product_priceWithoutTax, product_basePriceWithTax, product_tax";
                    string iq = "SELECT " + fields + " FROM `qz3vf_virtuemart_order_items` WHERE virtuemart_order_id = " + orderID + "";
                    DataTable items = mysql.QSelect(iq);

                    int itemCount = items.Rows.Count;
                    for (int j = 0; j <= itemCount - 1; j++)
                    {
                        DataRow item = items.Rows[j];
                        string item_fields = this.getTetelFields();
                        string item_values = this.getTetelValue(lastID.ToString(), item);
                        MessageBox.Show(item_values);
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

            notif.BalloonTipText = retString;
            notif.ShowBalloonTip(1000);
            return retString;
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
            //vals.length = 38;
            string vals = "'FELRE_" + row["ident"] + "'," +
                "" + ld.getLocalYear().Replace(".",string.Empty) + "," +
                "0," +
                "'Webshop'," +
                "'Webshop adatok'," +
                "0," +
                "'" + row["vezeteknev"] + " " + row["keresztnev"] + "'," +
                "'" + row["irsz"] + " " + row["varos"] + ", " + row["cim"] + " " + row["cim2"] + "'," +
                "2," +
                "'átutalás'," +

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
                "''," +
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
