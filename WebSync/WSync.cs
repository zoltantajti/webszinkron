using Database;
using Datum;

namespace WebSync
{
    public class WSync
    {
        private MySQL mysql;
        private MSSQL mssql;
        private LocalDate ld;

        public string Run()
        {
            mysql = new MySQL();
            mssql = new MSSQL();
            ld = new LocalDate();
            string syncStart = ld.getLocalTime();





            return syncStart + " > Szinkronizálva...";
        }

        
    }
}
