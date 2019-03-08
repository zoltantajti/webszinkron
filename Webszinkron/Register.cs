using System;
using System.Windows.Forms;
using Crypting;

namespace Webszinkron
{
    public partial class Register : Form
    {
        MainForm mf;
        License lic;
        WebApi api;

        public Register(MainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            lic = new License();
            api = new WebApi();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text;
            string email = tb_email.Text;
            string serial = tb_serial.Text;
            bool response = api.checkLicelse(name, email, serial);
            if (response == false)
            {
                if(MessageBox.Show("Hibás regisztrációs adatok!\r\nA példány nincs regisztrálva", "Regisztrációs hiba", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    clearFields();
                }
                else
                {
                    mf.close();
                }
            }
            else
            {
                string license = "[licensekey.dat]\r\nreguser=" + name + "\r\nemail=" + email + "\r\nserial=" + serial + "\r\n[licensekey.end]";
                lic.writeLicense(license);
                MessageBox.Show("Sikeres aktiválás!", "Aktiválás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        private void clearFields()
        {
            tb_email.Text = string.Empty;
            tb_username.Text = string.Empty;
            tb_serial.Text = string.Empty;
        }
    }

}
