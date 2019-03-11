namespace Webszinkron
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footStrip = new System.Windows.Forms.StatusStrip();
            this.tlbl_license = new System.Windows.Forms.ToolStripStatusLabel();
            this.notif = new System.Windows.Forms.NotifyIcon(this.components);
            this.notif_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.t_sync = new System.Windows.Forms.Timer(this.components);
            this.lb_nextSync = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_countdown = new System.Windows.Forms.Timer(this.components);
            this.headMenu.SuspendLayout();
            this.footStrip.SuspendLayout();
            this.notif_CMS.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headMenu
            // 
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.beállításokToolStripMenuItem1,
            this.súgóToolStripMenuItem});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(802, 24);
            this.headMenu.TabIndex = 0;
            this.headMenu.Text = "HeadMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem1
            // 
            this.beállításokToolStripMenuItem1.Name = "beállításokToolStripMenuItem1";
            this.beállításokToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem1.Text = "Beállítások";
            this.beállításokToolStripMenuItem1.Click += new System.EventHandler(this.beállításokToolStripMenuItem1_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
            // 
            // footStrip
            // 
            this.footStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbl_license,
            this.lb_nextSync});
            this.footStrip.Location = new System.Drawing.Point(0, 352);
            this.footStrip.Name = "footStrip";
            this.footStrip.Size = new System.Drawing.Size(802, 22);
            this.footStrip.TabIndex = 1;
            this.footStrip.Text = "statusStrip1";
            // 
            // tlbl_license
            // 
            this.tlbl_license.Name = "tlbl_license";
            this.tlbl_license.Size = new System.Drawing.Size(118, 17);
            this.tlbl_license.Text = "toolStripStatusLabel1";
            // 
            // notif
            // 
            this.notif.Text = "notifyIcon1";
            this.notif.Visible = true;
            // 
            // notif_CMS
            // 
            this.notif_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProgram,
            this.kilépésToolStripMenuItem1});
            this.notif_CMS.Name = "notif_CMS";
            this.notif_CMS.Size = new System.Drawing.Size(151, 48);
            // 
            // showProgram
            // 
            this.showProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showProgram.Image = ((System.Drawing.Image)(resources.GetObject("showProgram.Image")));
            this.showProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showProgram.Name = "showProgram";
            this.showProgram.Size = new System.Drawing.Size(150, 22);
            this.showProgram.Text = "Előtérbe hozás";
            this.showProgram.Click += new System.EventHandler(this.showProgram_Click);
            // 
            // kilépésToolStripMenuItem1
            // 
            this.kilépésToolStripMenuItem1.Name = "kilépésToolStripMenuItem1";
            this.kilépésToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.kilépésToolStripMenuItem1.Text = "Kilépés";
            this.kilépésToolStripMenuItem1.Click += new System.EventHandler(this.kilépésToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 328);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtb_log);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 322);
            this.panel1.TabIndex = 0;
            // 
            // rtb_log
            // 
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Location = new System.Drawing.Point(0, 0);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.Size = new System.Drawing.Size(686, 322);
            this.rtb_log.TabIndex = 0;
            this.rtb_log.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Sync);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(695, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 322);
            this.panel2.TabIndex = 1;
            // 
            // btn_Sync
            // 
            this.btn_Sync.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sync.Location = new System.Drawing.Point(0, 0);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(104, 55);
            this.btn_Sync.TabIndex = 0;
            this.btn_Sync.Text = "Szinkronizálás most";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // t_sync
            // 
            this.t_sync.Tick += new System.EventHandler(this.t_sync_Tick);
            // 
            // lb_nextSync
            // 
            this.lb_nextSync.Name = "lb_nextSync";
            this.lb_nextSync.Size = new System.Drawing.Size(638, 17);
            this.lb_nextSync.Spring = true;
            this.lb_nextSync.Text = "toolStripStatusLabel1";
            this.lb_nextSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_countdown
            // 
            this.t_countdown.Interval = 1000;
            this.t_countdown.Tick += new System.EventHandler(this.t_countdown_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.headMenu);
            this.Controls.Add(this.footStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.headMenu;
            this.Name = "MainForm";
            this.Text = "Webszinkron";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.footStrip.ResumeLayout(false);
            this.footStrip.PerformLayout();
            this.notif_CMS.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.StatusStrip footStrip;
        private System.Windows.Forms.ToolStripStatusLabel tlbl_license;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notif;
        private System.Windows.Forms.ContextMenuStrip notif_CMS;
        private System.Windows.Forms.ToolStripMenuItem showProgram;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Sync;
        public System.Windows.Forms.RichTextBox rtb_log;
        public System.Windows.Forms.Timer t_sync;
        private System.Windows.Forms.ToolStripStatusLabel lb_nextSync;
        private System.Windows.Forms.Timer t_countdown;
    }
}

