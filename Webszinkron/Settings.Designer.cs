namespace Webszinkron
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_set_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_set_sql_test = new System.Windows.Forms.Button();
            this.tb_mysql_dbname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mysql_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mysql_user = new System.Windows.Forms.TextBox();
            this.tb_timer = new System.Windows.Forms.TextBox();
            this.tp_sync = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mysql_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_set_cancel = new System.Windows.Forms.Button();
            this.tp_mysql = new System.Windows.Forms.TabPage();
            this.tb_mysql_host = new System.Windows.Forms.TextBox();
            this.tc_settings = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.tp_sync.SuspendLayout();
            this.tp_mysql.SuspendLayout();
            this.tc_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_set_save
            // 
            this.btn_set_save.Location = new System.Drawing.Point(86, 416);
            this.btn_set_save.Name = "btn_set_save";
            this.btn_set_save.Size = new System.Drawing.Size(75, 23);
            this.btn_set_save.TabIndex = 5;
            this.btn_set_save.Text = "Mentés";
            this.btn_set_save.UseVisualStyleBackColor = true;
            this.btn_set_save.Click += new System.EventHandler(this.btn_set_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Időzítő beállítása:";
            // 
            // btn_set_sql_test
            // 
            this.btn_set_sql_test.Location = new System.Drawing.Point(205, 126);
            this.btn_set_sql_test.Name = "btn_set_sql_test";
            this.btn_set_sql_test.Size = new System.Drawing.Size(107, 23);
            this.btn_set_sql_test.TabIndex = 10;
            this.btn_set_sql_test.Text = "Teszt";
            this.btn_set_sql_test.UseVisualStyleBackColor = true;
            this.btn_set_sql_test.Click += new System.EventHandler(this.btn_set_sql_test_Click);
            // 
            // tb_mysql_dbname
            // 
            this.tb_mysql_dbname.Location = new System.Drawing.Point(120, 100);
            this.tb_mysql_dbname.Name = "tb_mysql_dbname";
            this.tb_mysql_dbname.Size = new System.Drawing.Size(192, 20);
            this.tb_mysql_dbname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mysql adatbázis név:";
            // 
            // tb_mysql_pass
            // 
            this.tb_mysql_pass.Location = new System.Drawing.Point(120, 69);
            this.tb_mysql_pass.Name = "tb_mysql_pass";
            this.tb_mysql_pass.Size = new System.Drawing.Size(192, 20);
            this.tb_mysql_pass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mysql jelszó:";
            // 
            // tb_mysql_user
            // 
            this.tb_mysql_user.Location = new System.Drawing.Point(120, 38);
            this.tb_mysql_user.Name = "tb_mysql_user";
            this.tb_mysql_user.Size = new System.Drawing.Size(192, 20);
            this.tb_mysql_user.TabIndex = 5;
            // 
            // tb_timer
            // 
            this.tb_timer.Location = new System.Drawing.Point(107, 10);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(100, 20);
            this.tb_timer.TabIndex = 1;
            // 
            // tp_sync
            // 
            this.tp_sync.Controls.Add(this.label7);
            this.tp_sync.Controls.Add(this.tb_timer);
            this.tp_sync.Controls.Add(this.label6);
            this.tp_sync.Location = new System.Drawing.Point(4, 22);
            this.tp_sync.Name = "tp_sync";
            this.tp_sync.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sync.Size = new System.Drawing.Size(791, 377);
            this.tp_sync.TabIndex = 1;
            this.tp_sync.Text = "Szinkronizálás";
            this.tp_sync.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mysql felhasználó:";
            // 
            // tb_mysql_port
            // 
            this.tb_mysql_port.Location = new System.Drawing.Point(263, 8);
            this.tb_mysql_port.Name = "tb_mysql_port";
            this.tb_mysql_port.Size = new System.Drawing.Size(49, 20);
            this.tb_mysql_port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mysql kiszolgáló:";
            // 
            // btn_set_cancel
            // 
            this.btn_set_cancel.Location = new System.Drawing.Point(5, 416);
            this.btn_set_cancel.Name = "btn_set_cancel";
            this.btn_set_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_set_cancel.TabIndex = 4;
            this.btn_set_cancel.Text = "Mégse";
            this.btn_set_cancel.UseVisualStyleBackColor = true;
            this.btn_set_cancel.Click += new System.EventHandler(this.btn_set_cancel_Click);
            // 
            // tp_mysql
            // 
            this.tp_mysql.Controls.Add(this.btn_set_sql_test);
            this.tp_mysql.Controls.Add(this.tb_mysql_dbname);
            this.tp_mysql.Controls.Add(this.label5);
            this.tp_mysql.Controls.Add(this.tb_mysql_pass);
            this.tp_mysql.Controls.Add(this.label4);
            this.tp_mysql.Controls.Add(this.tb_mysql_user);
            this.tp_mysql.Controls.Add(this.label3);
            this.tp_mysql.Controls.Add(this.tb_mysql_port);
            this.tp_mysql.Controls.Add(this.tb_mysql_host);
            this.tp_mysql.Controls.Add(this.label2);
            this.tp_mysql.Controls.Add(this.label1);
            this.tp_mysql.Location = new System.Drawing.Point(4, 22);
            this.tp_mysql.Name = "tp_mysql";
            this.tp_mysql.Padding = new System.Windows.Forms.Padding(3);
            this.tp_mysql.Size = new System.Drawing.Size(791, 377);
            this.tp_mysql.TabIndex = 0;
            this.tp_mysql.Text = "Mysql Adatbázis";
            this.tp_mysql.UseVisualStyleBackColor = true;
            // 
            // tb_mysql_host
            // 
            this.tb_mysql_host.Location = new System.Drawing.Point(120, 8);
            this.tb_mysql_host.Name = "tb_mysql_host";
            this.tb_mysql_host.Size = new System.Drawing.Size(129, 20);
            this.tb_mysql_host.TabIndex = 2;
            // 
            // tc_settings
            // 
            this.tc_settings.Controls.Add(this.tp_mysql);
            this.tc_settings.Controls.Add(this.tp_sync);
            this.tc_settings.Location = new System.Drawing.Point(1, 11);
            this.tc_settings.Name = "tc_settings";
            this.tc_settings.SelectedIndex = 0;
            this.tc_settings.Size = new System.Drawing.Size(799, 403);
            this.tc_settings.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "másodperc";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_set_save);
            this.Controls.Add(this.btn_set_cancel);
            this.Controls.Add(this.tc_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beállítások";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.tp_sync.ResumeLayout(false);
            this.tp_sync.PerformLayout();
            this.tp_mysql.ResumeLayout(false);
            this.tp_mysql.PerformLayout();
            this.tc_settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_set_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_set_sql_test;
        private System.Windows.Forms.TextBox tb_mysql_dbname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mysql_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mysql_user;
        private System.Windows.Forms.TextBox tb_timer;
        private System.Windows.Forms.TabPage tp_sync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mysql_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_set_cancel;
        private System.Windows.Forms.TabPage tp_mysql;
        private System.Windows.Forms.TextBox tb_mysql_host;
        private System.Windows.Forms.TabControl tc_settings;
        private System.Windows.Forms.Label label7;
    }
}