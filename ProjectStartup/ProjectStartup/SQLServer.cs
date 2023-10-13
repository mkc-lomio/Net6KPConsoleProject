using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class SQLServer
    {
        public static void OpenSqlServerManagementStudio()
        {
            string ssmsPath = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 19\Common7\IDE\Ssms.exe"; 

            Process.Start(ssmsPath);
        }
    }
}
