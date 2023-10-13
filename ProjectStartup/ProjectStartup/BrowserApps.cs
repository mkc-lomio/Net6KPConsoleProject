using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class BrowserApps
    {

        public static void OpenSSM()
        {
            string path = $@"C:\Users\Marc Kenneth Lomio\Desktop\Screenshot Monitor.lnk";

            Process.Start("explorer.exe", path);
        }

        public static void OpenPomofocus()
        {
            string path = $@"C:\Users\Marc Kenneth Lomio\Desktop\Pomofocus.lnk";

            Process.Start("explorer.exe", path);
        }

        public static void OpenTrello()
        {
            string path = $@"C:\Users\Marc Kenneth Lomio\Desktop\Trello.lnk";

            Process.Start("explorer.exe", path);
        }
    }
}
