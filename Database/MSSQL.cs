using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configuration;
using Crypting;
namespace Database
{
    public class MSSQL
    {
        public Cfg cfg;
        private SqlConnection conn;
        private Base64 base64;
        private string file;
        private string cs;
        public MSSQL(int autoconnect = 0)
        {
            cfg = new Cfg();
            file = cfg.getCfg("mssqlfile");
            base64 = new Base64();
            conn = new SqlConnection();
            string dbfile = cfg.getCfg("mssqldbname");
            string[] db = dbfile.Split('.');
            string dbname = db[0];
            cs = @"Data Source=(local)\NATURASOFT;Database="+dbname+";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false";
            conn.ConnectionString = cs;
            if(autoconnect == 1)
            {
                this.OpenConnection("Autoconnect");
            }
        }
        private bool OpenConnection(string debug = "")
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show(debug + "\r\n" + ex.Message, "MSSQL Csatlakozási Hiba", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                //MessageBox.Show(debug + "\r\nA kapcsolat már nyitva van!", "MSSQL Csatlakozás", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable Select(string tabla, string mit = "*", string cond = "", string reference="")
        {
            DataTable resp = new DataTable();
            string query = "SELECT " + mit + " FROM " + tabla + " " + cond;
            if (this.OpenConnection() == true)
            {
                DataTable ret = new DataTable();
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ret);
                        this.CloseConnection();
                        return ret;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return ret;
                    }
                }
                else
                {
                    return ret;
                }
            };
            return resp;
        }
        public int LastIndex(string tabla, string mit = "ID", string cond = "")
        {
            string qry = "SELECT max(" + mit + ") FROM " + tabla;
            if(this.OpenConnection("LastINdex") == true)
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                int last = (int)cmd.ExecuteScalar();
                this.CloseConnection();
                return last;
            }
            return 0;
        }
        public int Count(string tabla, string mit="*", string cond = "")
        {
            string qry = "SELECT " + mit + " FROM " + tabla + " " + cond;
            if(this.OpenConnection("Count") == true)
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                int count = (int)cmd.ExecuteScalar();
                this.CloseConnection();
                return count;
            }
            else
            {
                return 0;
            }
        }
        public void Insert(string tabla, string fields, string values)
        {
            string query = "INSERT INTO " + tabla + " (" + fields + ") VALUES (" + values + ")";
            if(this.OpenConnection("Insert") == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, "MSSQL Beviteli Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        public void changeFile(string newfile)
        {
            file = newfile;
        }
    }
}
