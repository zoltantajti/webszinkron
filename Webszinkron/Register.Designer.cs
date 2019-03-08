namespace Webszinkron
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail cím:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(15, 25);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(182, 20);
            this.tb_username.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(15, 68);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(182, 20);
            this.tb_email.TabIndex = 4;
            // 
            // tb_serial
            // 
            this.tb_serial.Location = new System.Drawing.Point(15, 112);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.Size = new System.Drawing.Size(182, 20);
            this.tb_serial.TabIndex = 5;
            // 
            // btnAct
            // 
            this.btnAct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAct.Location = new System.Drawing.Point(65, 147);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 6;
            this.btnAct.Text = "Aktiválás";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 182);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktiválás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.Button btnAct;
    }
}