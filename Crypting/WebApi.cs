using System.Net;

namespace Crypting
{
    public class WebApi
    {
        private string url = "http://api.tajtihost.space/api.php";
        public bool checkLicelse(string name, string mail, string serial)
        {
            WebClient client = new WebClient();
            string pars = "?name=" + name + "&email=" + mail + "&serial=" + serial;
            string resp = client.DownloadString(url + pars);
            if (resp == "false")
            {
                return false;
            }
            else if (resp == "true")
            {
                return true;
            }
            else return false;
        }
    }
}
