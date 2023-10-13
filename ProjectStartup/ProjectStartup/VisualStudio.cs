using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStartup
{
    public class VisualStudio
    {
        public static void OpenVisualStudioProject(string solutionPath)
        {

            if (string.IsNullOrEmpty(solutionPath))
            {
                throw new ArgumentNullException(nameof(solutionPath));
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe"; // Path for VS 2022 Community Edition
            startInfo.Arguments = "\"" + solutionPath + "\"";

            Process.Start(startInfo);
        }
    }
}
