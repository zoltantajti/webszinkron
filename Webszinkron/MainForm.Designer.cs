﻿namespace Webszinkron
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
            this.contextMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu.SuspendLayout();
            this.footStrip.SuspendLayout();
            this.contextMS.SuspendLayout();
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
            this.headMenu.Size = new System.Drawing.Size(1239, 24);
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
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem1
            // 
            this.beállításokToolStripMenuItem1.Name = "beállításokToolStripMenuItem1";
            this.beállításokToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem1.Text = "Beállítások";
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
            this.tlbl_license});
            this.footStrip.Location = new System.Drawing.Point(0, 643);
            this.footStrip.Name = "footStrip";
            this.footStrip.Size = new System.Drawing.Size(1239, 22);
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
            // contextMS
            // 
            this.contextMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProgram});
            this.contextMS.Name = "contextMS";
            this.contextMS.Size = new System.Drawing.Size(151, 26);
            // 
            // showProgram
            // 
            this.showProgram.Name = "showProgram";
            this.showProgram.Size = new System.Drawing.Size(180, 22);
            this.showProgram.Text = "Előtérbe hozás";
            this.showProgram.Click += new System.EventHandler(this.showProgram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 665);
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
            this.contextMS.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMS;
        private System.Windows.Forms.ToolStripMenuItem showProgram;
    }
}

