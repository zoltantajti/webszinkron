using System;
using System.Data;
using System.Text;

namespace Crypting
{
    public class Base64
    {
        public string encode(string pText)
        {
            var pTextB = Encoding.UTF8.GetBytes(pText);
            return Convert.ToBase64String(pTextB);
        }
        public string decode(string hash)
        {
            var hashB = Convert.FromBase64String(hash);
            return Encoding.UTF8.GetString(hashB);
        }
        public string getCheckSum(DataRow row, string fieldKey1, string fieldKey2)
        {
            string hash = this.encode(row[fieldKey1].ToString() + row[fieldKey2].ToString());
            return hash;
        }
        public bool ChechHash(string hash1, string hash2)
        {
            if (hash1 == hash2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
