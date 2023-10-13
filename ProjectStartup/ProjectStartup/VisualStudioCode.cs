using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class VisualStudioCode
    {
        public static void OpenFolderInVSCode(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                throw new ArgumentNullException(nameof(folderPath));
            }

            string vscodeExecutablePath = @"C:\Users\Marc Kenneth Lomio\AppData\Local\Programs\Microsoft VS Code\Code.exe";

            Process.Start(vscodeExecutablePath, folderPath);

            string batchFilePath = @"C:\Users\Marc Kenneth Lomio\source\repos\Net6KPConsoleProject\ng-start-kp-spa.bat"; 

            Process.Start(batchFilePath, folderPath);
        }
    }
}
