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
    }
}
