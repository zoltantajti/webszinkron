using System;
using System.IO;
using System.Text;

namespace Crypting
{
    public class License
    {
        public int nameRow = 1;
        public int mailRow = 2;
        public int serRow = 3;
        public string Encrypt(string value)
        {
            string result = "";
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    byte[] bytes = UnicodeEncoding.UTF8.GetBytes(value);
                    result = Convert.ToBase64String(bytes);
                }
            }
            catch { }

            return result;
        }


        public string Decrypt(string value)
        {
            string result = "";
            try
            {
                byte[] bytes = Convert.FromBase64String(value);

                result = Encoding.UTF8.GetString(bytes);
            }
            catch { }

            return result;
        }

        public bool readKey()
        {
            if (File.Exists("license.dat"))
            {
                return true;
            }
            else return false;
        }

        public string readLicense()
        {
            if (readKey() == true)
            {
                string text = File.ReadAllText("license.dat");
                text = Decrypt(text);
                return text;
            }
            else
            {
                return "Error" ;
            }
        }

        public void writeLicense(string lic)
        {
            string text = Encrypt(lic);
            File.WriteAllText("license.dat", text);
        }
    }
}
