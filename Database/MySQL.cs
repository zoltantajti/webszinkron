using System.Windows.Forms;
using Configuration;
using MySql.Data.MySqlClient;
using EHandler;
using System.Collections.Generic;
using System.Data;

namespace Database
{
    public interface Idb
    {
        void SendMessage(string msg, string title);
    }
    public class MySQL
    {
        private Cfg cfg;
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string pwd;
        private string cs;
        
        public void DBConnect()
        {
            cfg = new Cfg();
            cfg.readCfg();
            
            Initialize();
        }

        private void Initialize()
        {
            server = cfg.getCfg("sqlhost");
            uid = cfg.getCfg("sqluser");
            pwd = cfg.getCfg("sqlpass");
            database = cfg.getCfg("sqldb");
            cs = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            conn = new MySqlConnection(cs);
        }

        public string TestConnection(string host, string db, string u, string pw)
        {
            string cstring = "SERVER=" + host + ";" + "DATABASE=" + db + ";" + "UID=" + u + ";" + "PASSWORD=" + pw + ";";
            MySqlConnection c = new MySqlConnection(cstring);
            string resp = string.Empty;
            try
            {
                c.Open();
                resp = "Kapcsolat rendben!";
            }
            catch (MySqlException ex)
            {
                
                switch (ex.Number)
                {
                    case 0:
                        resp = "A szerver nem érhető el!";
                        break;

                    case 1045:
                        resp = "Hibás felhasználónév/jelszó!";
                        break;
                    default:
                        resp = ex.Message;
                        break;
                }
            };
            try
            {
                c.Close();
            }catch(MySqlException ex){};
            return resp;
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }


        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string tabla, string set)
        {
            string query = "INSERT INTO " + tabla + " SET " + set + "";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update(string tabla, string set, string cond = "")
        {
            string query = "UPDATE " + tabla + " SET " + set + " " + cond;
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Delete(string tabla, string cond = "")
        {
            string query = "DELETE FROM " + tabla + " " + cond;
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public int QCount(string q)
        {
            int count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(q, conn);
                count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return count;
            }
            else
            {
                return count;
            }
        }

        public int Count(string tabla, string mit = "*", string cond = "")
        {
            string query = "SELECT " + mit + " FROM " + tabla + " " + cond;
            int count = -1;
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return count;
            }
            else
            {
                return count;
            }
        }

        private int GetColumnsCount(string tabla)
        {
            string query = "SELECT count(*) FROM `information_schema.columns WHERE table_name = '" + tabla + "'";
            int count = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return count;
            }
            else
            {
                return count;
            }
        }

        public DataTable Select(string tabla, string mit = "*", string cond = "")
        {
            string query = "SELECT " + mit + " FROM " + tabla + " " + cond;
            DataTable ret = new DataTable();
            if(this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ret);
                    this.CloseConnection();
                    return ret;
                }catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ret;
                }
            }
            else
            {
                return ret;
            }
        }

        public DataTable QSelect(string qry)
        {
            DataTable ret = new DataTable();
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ret);
                    this.CloseConnection();
                    return ret;

                }
                else
                {
                    MessageBox.Show("Nincs kapcsolódva");
                    return ret;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return ret;
            };
        }
    }
}
