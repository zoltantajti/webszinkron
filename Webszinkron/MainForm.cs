using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

using Crypting;
using Configuration;
using Database;
using Datum;
using WebSync;

namespace Webszinkron
{
    public partial class MainForm : Form
    {
        #region deklarációk
        private License lic;
        public Cfg cfg;
        public MySQL mysql;
        public MSSQL mssql;
        public LocalDate local;
        public WSync wsync;
        
        public string lic_name;
        public string lic_mail;
        public string lic_serial;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Licenselés
            lic = new License();
            if(lic.readKey() == false)
            {
                using(Register regForm = new Register(this))
                {
                    if(regForm.ShowDialog() == DialogResult.OK)
                    {
                        readLicense();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                readLicense();
            }
            #endregion

            cfg = new Cfg();
            mysql = new MySQL();
            mssql = new MSSQL();
            local = new LocalDate();
            wsync = new WSync();

            Sync(); //Program indításkor automatikusan szinkronizál!
            t_sync.Start();
            updateTimerInterval();
            rtb_log.ReadOnly = true;
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            Sync();
        }

        #region License publikussá tétele
        private void readLicense()
        {
            string license = lic.readLicense();
            string[] lrows = license.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string[] lrow1 = lrows[lic.nameRow].Split('=');
            string[] lrow2 = lrows[lic.mailRow].Split('=');
            string[] lrow3 = lrows[lic.serRow].Split('=');
            lic_name = lrow1[1];
            lic_mail = lrow2[1];
            lic_serial = lrow3[1];
            tlbl_license.Text = lic_name;
        }
        #endregion
       
        #region ExitFunctions
        public void close()
        {
            ShowNotif("Webszinkron", "A program most kilép!\r\nA szinkronizálás leáll...", ToolTipIcon.Warning);
            Application.Exit();
            Application.ExitThread();
        }
        private void exit_Click(object sender, System.EventArgs e)
        {
            close();
        }
        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }
        #endregion
        
        #region Notification
        private void MainForm_Load(object sender, EventArgs e)
        {
            notif.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory() + @"\sync.ico");
            notif.Text = "Webszinkron";
            notif.Visible = true;
            notif.DoubleClick += new EventHandler(this.notif_DoubleClick);
            
            
        }
        private void ShowNotif(string title, string text, ToolTipIcon icon)
        {
            notif.BalloonTipIcon = icon;
            notif.BalloonTipText = text;
            notif.BalloonTipTitle = title;
            notif.ContextMenuStrip = notif_CMS;
            notif.ShowBalloonTip(1000);
        }
        public void MakeNotif(string title, string text, ToolTipIcon icon)
        {
            ShowNotif(title, text, icon);
        }
        private void showProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        private void notif_DoubleClick(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        private void kilépésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            close();
        }
        #endregion

        #region WriteDisplayLog
        private void writeLog(string text, int type = 0)
        {
            rtb_log.Text += text + Environment.NewLine;
            rtb_log.ScrollToCaret();
            if (type == 0)
            { //Default log
                rtb_log.Find(text);
                rtb_log.SelectionColor = Color.Black;
                rtb_log.Select(rtb_log.Text.Length - 1, 0);
            }else if(type == 1)
            { //warning log
                rtb_log.Find(text);
                rtb_log.SelectionColor = Color.DarkOrange;
                rtb_log.Select(rtb_log.Text.Length - 1, 0);
            }
            else if (type == 2)
            { //error log
                rtb_log.Find(text);
                rtb_log.SelectionColor = Color.Red;
                rtb_log.Select(rtb_log.Text.Length - 1, 0);
            }
        }
        #endregion

        #region timerSync
        public void updateTimerInterval(int _int = 0)
        {
            int interval;
            if (_int == 0) { interval = int.Parse(cfg.getCfg("interval")); } else { interval = _int; }
            t_sync.Interval = interval;
        }
        
        private void t_sync_Tick(object sender, EventArgs e)
        {
            Sync();
        }
        #endregion

        #region navbar
        private void beállításokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }
        #endregion

        #region Sync functions
        private void Sync()
        {
            /*string time = local.getLocalTime();
            writeLog(time + " > Szinkronizálás...", 0);*/
            writeLog(wsync.Run(), 0);
        }
        #endregion

        
    }
}
