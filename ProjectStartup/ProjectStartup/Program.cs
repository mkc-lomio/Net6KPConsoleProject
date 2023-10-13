
// See https://aka.ms/new-console-template for more information
using ProjectStartup;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Clear(); 


Console.WriteLine("                                                     .--.__");
Console.WriteLine("                                                      .~ (@)  ~~~---_");
Console.WriteLine("                                                     {     `-_~,,,,,,)");
Console.WriteLine("                                                     {    (_  ',");
Console.WriteLine("                                                      ~    . = _',");
Console.WriteLine("                                                       ~-   '.  =-'");
Console.WriteLine("                                                         ~     :");
Console.WriteLine("      .                                             _,.-~     ('');");
Console.WriteLine("      '.                                         .-~        \\  \\ ;");
Console.WriteLine("        ':-_                                _.--~            \\  \\;      _-=,.");
Console.WriteLine("          ~-:-.__                       _.-~                 {  '---- _'-=,.");
Console.WriteLine("             ~-._~--._             __.-~                     ~---------=,.`");
Console.WriteLine("                 ~~-._~~-----~~~~~~       .+++~~~~~~~~-__   /");
Console.WriteLine("                      ~-.,____           {   -     +   }  _/");
Console.WriteLine("                              ~~-.______{_    _ -=\\ / /_.~");
Console.WriteLine("                                   :      ~--~    // /         ..-");
Console.WriteLine("                                   :   / /      // /         ((");
Console.WriteLine("                                   :  / /      {   `-------,. ))");
Console.WriteLine("                                   :   /        ''=--------. }o");
Console.WriteLine("                      .=._________,'  )                     ))");
Console.WriteLine("                      )  _________ -''                     ~~");
Console.WriteLine("                     / /  _ _");
Console.WriteLine("                    (_.-.'O'-'.        \"Welcome to KIS Work Setup\"");

Console.WriteLine("^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");

int milliseconds = 3000;

Console.Write("Do you like to start (Y/N)?");

string? start = Console.ReadLine();

if (!string.IsNullOrEmpty(start) &&
    start?.ToUpper() == "Y") { 

    BrowserApps.OpenSSM();

    BrowserApps.OpenTrello();

    BrowserApps.OpenPomofocus();

    MicrosoftApps.OpenOutlook();

    MicrosoftApps.OpenTeams();

    Thread.Sleep(milliseconds);

    Postman.OpenPostman();

    Thread.Sleep(milliseconds);

    SQLServer.OpenSqlServerManagementStudio();

    Thread.Sleep(milliseconds);

    string solutionPath = @"C:\Kinetic\PortalDevDotNetAPICode\KineticAPI.sln";
    VisualStudio.OpenVisualStudioProject(solutionPath);

    Thread.Sleep(milliseconds);

    string folderToOpen = @"C:\Kinetic\PortalDevAngularCode";
    VisualStudioCode.OpenFolderInVSCode(folderToOpen);

    Thread.Sleep(milliseconds);
}





