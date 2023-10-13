using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class Postman
    {
        public static void OpenPostman()
        {
            string postmanPath = $@"C:\Users\{Environment.UserName}\AppData\Local\Postman\Postman.exe";

            Process.Start(postmanPath);
        }
    }
}
