using Database;
using System.Data;
using Crypting;

namespace ProductSync
{
    public class Prices
    {
        private MSSQL mssql;
        private MySQL mysql;
        private Base64 base64;

        public string updatePrices(MySQL mysql, MSSQL mssql)
        {
            DataTable mssql_base = mssql.Select("termek", "*");
            /*foreach(DataRow termek in mssql_base.Rows)
            {
                string hash = base64.getCheckSum(termek, "TERMEKKOD", "NETTOAR");
                string q = "SELECT prod.product_sku as prodcode, price.product_price as netto " +
                    "FROM qz3vf_virtuemart_products as prod LEFT JOIN qz3vf_virtuemart_product_prices as price ON (prod.virtuemart_product_id = price.virtuemart_product_id) " +
                    "WHERE prod.product_sku = " + termek["TERMEKKOD"] + "";
                DataTable mysql_res = mysql.QSelect(q);
                string mysqlHash = base64.getCheckSum(mysql_res.Rows[0], "prodcode", "netto");
                if(base64.ChechHash(hash, mysqlHash))
                {
                    return termek["TERMEKKOD"] + " ára változott";
                }
            }*/
            return "Ár";

        }
    }
}
