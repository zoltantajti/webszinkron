using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum
{
    public class LocalDate
    {
        public string getLocalTime()
        {
            DateTime local = DateTime.Now;
            string patt = @"HH:mm:ss ";
            return local.ToString(patt);
        }

        public string getLocalYear()
        {
            DateTime local = DateTime.Now;
            string patt = @"yyyy";
            return local.ToString(patt);
        }

        public string getSqlDateTime()
        {
            DateTime local = DateTime.Now;
            string patt = @"yyyy-MM-dd 00:00:00";
            return local.ToString(patt);
        }
    }
}
