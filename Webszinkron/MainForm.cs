using System;
using System.IO;
using System.Windows.Forms;
using Crypting;

namespace Webszinkron
{
    public partial class MainForm : Form
    {
        #region deklarációk
        private License lic;
        
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
            ShowNotif("A program elindult!", "A szinkron fut!", ToolTipIcon.Info);
        }
        private void ShowNotif(string title, string text, ToolTipIcon icon)
        {
            notif.BalloonTipIcon = icon;
            notif.BalloonTipText = text;
            notif.BalloonTipTitle = title;
            notif.ContextMenuStrip = contextMS;
            notif.ShowBalloonTip(1000);
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
        #endregion
    }
}
