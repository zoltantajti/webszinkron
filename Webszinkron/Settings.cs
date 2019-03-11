using Configuration;
using Database;
using System.Data;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace Webszinkron
{
    public partial class Settings : Form
    {
        Cfg cfg;
        MySQL mysql;
        MSSQL mssql;
        MainForm mf;
        public Settings(MainForm _mf)
        {
            InitializeComponent();
            cfg = new Cfg();
            mysql = new MySQL();
            mssql = new MSSQL();
            mf = _mf;
            mf.t_sync.Stop();
            FillForms();
        }

        private void FillForms()
        {
            tb_mysql_host.Text = cfg.getCfg("sqlhost");
            tb_mysql_port.Text = cfg.getCfg("sqlport");
            tb_mysql_user.Text = cfg.getCfg("sqluser");
            tb_mysql_pass.Text = cfg.getCfg("sqlpass");
            tb_mysql_dbname.Text = cfg.getCfg("sqldb");
            tb_timer.Text = (int.Parse(cfg.getCfg("interval")) / 1000).ToString();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.t_sync.Start();
        }

        private void btn_set_sql_test_Click(object sender, System.EventArgs e)
        {
            string testRes = mysql.TestConnection(tb_mysql_host.Text, tb_mysql_dbname.Text, tb_mysql_user.Text, tb_mysql_pass.Text);
            MessageBox.Show(testRes);
        }

        private void btn_set_cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_set_save_Click(object sender, System.EventArgs e)
        {
            string mysqlhost = tb_mysql_host.Text;
            string mysqluser = tb_mysql_user.Text;
            string mysqlpass = tb_mysql_pass.Text;
            string mysqldbase = tb_mysql_dbname.Text;
            string timer_interval = (int.Parse(tb_timer.Text) * 1000).ToString();

            string file = "[mysql]\r\n" +
                          "host="+mysqlhost+"\r\n" +
                          "port=3306\r\n" +
                          "user="+mysqluser+"\r\n" +
                          "pwd="+mysqlpass+"\r\n" +
                          "dbname="+mysqldbase+"\r\n" +
                          "[sync]\r\n" +
                          "timer="+timer_interval+"\r\n";

            cfg.writeCfg(file);
            cfg.readCfg();
            mf.updateTimerInterval(int.Parse(timer_interval));

            MessageBox.Show("A beállítások mentve!", "Beállítások", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_mssql_browse_Click(object sender, System.EventArgs e)
        {
            this.GrantAccess(ofd_mssql.InitialDirectory);
            ofd_mssql.Filter = "Adatbázis file (*.mdf)|*.mdf";
            ofd_mssql.ShowDialog();
            
        }

        private bool GrantAccess(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);
            DirectorySecurity dSec = dInfo.GetAccessControl();
            dSec.AddAccessRule(new FileSystemAccessRule(
                new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                PropagationFlags.NoPropagateInherit,
                AccessControlType.Allow));
            dInfo.SetAccessControl(dSec);
            return true;
        }
    }
}
