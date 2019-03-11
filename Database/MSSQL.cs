using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Configuration;
namespace Database
{
    public class MSSQL
    {
        public Cfg cfg;
        private SqlConnection conn;
        private string file;
        public MSSQL()
        {
            cfg = new Cfg();
            file = cfg.getCfg("mssqlfile");
            conn = new SqlConnection();
            string cs = @"Data Source=(local)\NATURASOFT;Database=ns_ftszamla_PrbaSQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn.ConnectionString = cs;
        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }catch(SqlException ex)
            {
                return false;
            }
        }
        public DataTable Select(string tabla, string mit = "*", string cond = "")
        {
            DataTable resp = new DataTable();
            string query = "SELECT " + mit + " FROM " + tabla + " " + cond;
            if (this.OpenConnection() == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(resp);
                    this.CloseConnection();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return resp;
            }
            else
            {
                return resp;
            }
        }
        public void Insert(string tabla, string fields, string values)
        {
            string query = "INSERT INTO " + tabla + " (" + fields + ") VALUES (" + values + ")";
            MessageBox.Show(query);
            if(this.OpenConnection() == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
        }

        public void changeFile(string newfile)
        {
            file = newfile;
        }
    }
}
