using Database;
using System.Data;
using Crypting;
using Datum;
using System.Windows.Forms;
using System;

namespace ProductSync
{
    public class Prices
    {
        private MSSQL mssql;
        private MySQL mysql;
        private Base64 base64;
        private LocalDate ld;

        public string updatePrices(NotifyIcon notif)
        {
            mssql = new MSSQL();
            mysql = new MySQL();
            mysql.DBConnect();
            base64 = new Base64();
            ld = new LocalDate();

            DataTable mssql_base = mssql.Select("termek", "*", "", "updatePrices");
            int all = 0;
            int mod = 0;
            int nm = 0;
            foreach (DataRow termek in mssql_base.Rows)
            {
                termek["NETTOAR"] = decimal.Parse(termek["NETTOAR"].ToString()).ToString("#.##");
                string hash = base64.getCheckSum(termek, "TERMEKKOD","NETTOAR");
                string q = "SELECT prod.product_sku as prodcode, price.product_price as netto, price.virtuemart_product_id as pid " +
                    "FROM qz3vf_virtuemart_products as prod LEFT JOIN qz3vf_virtuemart_product_prices as price ON (prod.virtuemart_product_id = price.virtuemart_product_id) " +
                    "WHERE prod.product_sku = '" + termek["TERMEKKOD"] + "'";
                DataTable mres = mysql.QSelect(q);
                mres.Rows[0]["netto"] = decimal.Parse(mres.Rows[0]["netto"].ToString()).ToString("#.##");
                string mysqlHash = base64.getCheckSum(mres.Rows[0], "prodcode", "netto");
                all++;
                if (base64.ChechHash(hash, mysqlHash))
                {
                    nm++;
                }
                else
                {
                    try
                    {
                        mysql.Update("qz3vf_virtuemart_product_prices", "product_price=" + termek["NETTOAR"] + "", "WHERE virtuemart_product_id = " + mres.Rows[0]["pid"] + "");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    mod++;
                }
            }
            
            if (mod > 0)
            {
                notif.BalloonTipIcon = ToolTipIcon.Info;
                notif.BalloonTipText = "Termékár frissítése: " + mod.ToString() + "db termék ára frissítve";
                notif.ShowBalloonTip(1000);
            }
            string ret = ld.getLocalTime() + "> Ár frissítés: Ellenőrizve: " + all + ", Firssítve: " + mod + ", Változatlan: " + nm;
            return ret;
        }
    }
}
