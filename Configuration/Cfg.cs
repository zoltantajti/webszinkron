using System.Windows.Forms;
using System.IO;

namespace Configuration
{
    public class Cfg
    {
        #region Mysql
        public string sqlhost;
        public string sqlport;
        public string sqluser;
        public string sqlpass;
        public string sqldbname;
        #endregion

        #region syncTick
        private int t_interval;
        #endregion

        #region MSSQL
        private string mssql_file;
        #endregion

        #region global
        private string config = "config.inc";
        private string line;
        #endregion

        public Cfg()
        {
            readCfg();
        }

        public void readCfg()
        {
            StreamReader reader = new StreamReader(config);
            while((line = reader.ReadLine()) != null)
            {
                string[] l = line.Split('=');
                if (l[0] == "host") { sqlhost = l[1]; };
                if (l[0] == "port") { sqlport = l[1]; };
                if (l[0] == "user") { sqluser = l[1]; };
                if (l[0] == "pwd") { sqlpass = l[1]; };
                if (l[0] == "dbname") { sqldbname = l[1]; };
                if (l[0] == "timer") { t_interval = int.Parse(l[1]); };
                if (l[0] == "mssqlfile") { mssql_file = l[1]; };
            }
            reader.Close();
        }

        public string getCfg(string mit)
        {
            string r;
            switch (mit)
            {
                case "sqlhost": r = sqlhost; break;
                case "sqlport": r = sqlport; break;
                case "sqluser": r = sqluser; break;
                case "sqlpass": r =  sqlpass; break;
                case "sqldb": r =  sqldbname; break;
                case "interval": r = t_interval.ToString(); break;
                case "mssqlfile": r = mssql_file; break;
                default: r = string.Empty; break;
            }
            return r;
        }

        public void writeCfg(string cfg)
        {
            File.WriteAllText(config, cfg);
        }
    }
}
