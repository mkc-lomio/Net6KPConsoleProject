using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class MicrosoftApps
    {
        public static void OpenTeams()
        {
            string teamsPath = $@"C:\Users\Marc Kenneth Lomio\Desktop\Microsoft Teams classic (work or school).lnk";

            Process.Start("explorer.exe", teamsPath);
        }

        public static void OpenOutlook()
        {

            string outlookPath = @"C:\Users\Marc Kenneth Lomio\Desktop\Outlook.lnk";

            Process.Start("explorer.exe",outlookPath);
        }
    }
}
