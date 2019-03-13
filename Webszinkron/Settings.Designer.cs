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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mysql_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_set_cancel = new System.Windows.Forms.Button();
            this.tp_mysql = new System.Windows.Forms.TabPage();
            this.tb_mysql_host = new System.Windows.Forms.TextBox();
            this.tc_settings = new System.Windows.Forms.TabControl();
            this.ofd_mssql = new System.Windows.Forms.OpenFileDialog();
            this.tp_mssql = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_mssqls = new System.Windows.Forms.ComboBox();
            this.tp_company = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cegnev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_asz1 = new System.Windows.Forms.TextBox();
            this.tb_cim = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_asz2 = new System.Windows.Forms.TextBox();
            this.tb_asz3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tp_sync.SuspendLayout();
            this.tp_mysql.SuspendLayout();
            this.tc_settings.SuspendLayout();
            this.tp_mssql.SuspendLayout();
            this.tp_company.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "másodperc";
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
            this.tc_settings.Controls.Add(this.tp_mssql);
            this.tc_settings.Controls.Add(this.tp_sync);
            this.tc_settings.Controls.Add(this.tp_company);
            this.tc_settings.Location = new System.Drawing.Point(1, 11);
            this.tc_settings.Name = "tc_settings";
            this.tc_settings.SelectedIndex = 0;
            this.tc_settings.Size = new System.Drawing.Size(799, 403);
            this.tc_settings.TabIndex = 3;
            // 
            // ofd_mssql
            // 
            this.ofd_mssql.DefaultExt = "mdf";
            this.ofd_mssql.Filter = "\"mdf files (*.mdf)|*.mdf\"";
            this.ofd_mssql.InitialDirectory = "C:\\";
            // 
            // tp_mssql
            // 
            this.tp_mssql.Controls.Add(this.cb_mssqls);
            this.tp_mssql.Controls.Add(this.label8);
            this.tp_mssql.Location = new System.Drawing.Point(4, 22);
            this.tp_mssql.Name = "tp_mssql";
            this.tp_mssql.Size = new System.Drawing.Size(791, 377);
            this.tp_mssql.TabIndex = 2;
            this.tp_mssql.Text = "MSSQL kiválasztása";
            this.tp_mssql.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "MSSQL adatbázis kiválasztása:";
            // 
            // cb_mssqls
            // 
            this.cb_mssqls.FormattingEnabled = true;
            this.cb_mssqls.Location = new System.Drawing.Point(169, 7);
            this.cb_mssqls.Name = "cb_mssqls";
            this.cb_mssqls.Size = new System.Drawing.Size(246, 21);
            this.cb_mssqls.TabIndex = 1;
            // 
            // tp_company
            // 
            this.tp_company.Controls.Add(this.tb_asz3);
            this.tp_company.Controls.Add(this.label13);
            this.tp_company.Controls.Add(this.tb_asz2);
            this.tp_company.Controls.Add(this.label12);
            this.tp_company.Controls.Add(this.tb_cim);
            this.tp_company.Controls.Add(this.tb_asz1);
            this.tp_company.Controls.Add(this.label11);
            this.tp_company.Controls.Add(this.label10);
            this.tp_company.Controls.Add(this.tb_cegnev);
            this.tp_company.Controls.Add(this.label9);
            this.tp_company.Location = new System.Drawing.Point(4, 22);
            this.tp_company.Name = "tp_company";
            this.tp_company.Size = new System.Drawing.Size(791, 377);
            this.tp_company.TabIndex = 3;
            this.tp_company.Text = "Cégadatok";
            this.tp_company.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cégnév:";
            // 
            // tb_cegnev
            // 
            this.tb_cegnev.Location = new System.Drawing.Point(81, 11);
            this.tb_cegnev.Name = "tb_cegnev";
            this.tb_cegnev.Size = new System.Drawing.Size(296, 20);
            this.tb_cegnev.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Adószám:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cím:";
            // 
            // tb_asz1
            // 
            this.tb_asz1.Location = new System.Drawing.Point(81, 37);
            this.tb_asz1.MaxLength = 8;
            this.tb_asz1.Name = "tb_asz1";
            this.tb_asz1.Size = new System.Drawing.Size(62, 20);
            this.tb_asz1.TabIndex = 4;
            this.tb_asz1.Text = "12345678";
            // 
            // tb_cim
            // 
            this.tb_cim.Location = new System.Drawing.Point(81, 64);
            this.tb_cim.Name = "tb_cim";
            this.tb_cim.Size = new System.Drawing.Size(296, 20);
            this.tb_cim.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "-";
            // 
            // tb_asz2
            // 
            this.tb_asz2.Location = new System.Drawing.Point(165, 37);
            this.tb_asz2.MaxLength = 1;
            this.tb_asz2.Name = "tb_asz2";
            this.tb_asz2.Size = new System.Drawing.Size(15, 20);
            this.tb_asz2.TabIndex = 7;
            this.tb_asz2.Text = "1";
            // 
            // tb_asz3
            // 
            this.tb_asz3.Location = new System.Drawing.Point(200, 37);
            this.tb_asz3.MaxLength = 2;
            this.tb_asz3.Name = "tb_asz3";
            this.tb_asz3.Size = new System.Drawing.Size(23, 20);
            this.tb_asz3.TabIndex = 9;
            this.tb_asz3.Text = "32";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "-";
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
            this.tp_mssql.ResumeLayout(false);
            this.tp_mssql.PerformLayout();
            this.tp_company.ResumeLayout(false);
            this.tp_company.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog ofd_mssql;
        private System.Windows.Forms.TabPage tp_mssql;
        private System.Windows.Forms.ComboBox cb_mssqls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tp_company;
        private System.Windows.Forms.TextBox tb_asz3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_asz2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_cim;
        private System.Windows.Forms.TextBox tb_asz1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cegnev;
        private System.Windows.Forms.Label label9;
    }
}