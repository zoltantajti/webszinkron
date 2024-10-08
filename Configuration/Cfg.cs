﻿using System.Windows.Forms;
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
        private string mssqldbname;
        #endregion

        #region Cégadatok
        private string cegnev;
        private string adoszam;
        private string cegcim;
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
                if (l[0] == "mssqldbname") { mssqldbname = l[1]; };
                if (l[0] == "cegnev") { cegnev = l[1]; };
                if (l[0] == "adoszam") { adoszam = l[1]; };
                if (l[0] == "cegcim") { cegcim = l[1]; };
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
                case "mssqldbname": r = mssqldbname; break;
                case "cegnev": r = cegnev; break;
                case "adoszam": r = adoszam; break;
                case "cegcim": r = cegcim; break;
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
