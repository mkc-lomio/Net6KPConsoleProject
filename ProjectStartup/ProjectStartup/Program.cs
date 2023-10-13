
// See https://aka.ms/new-console-template for more information
using ProjectStartup;
using System.Speech.Synthesis;

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


#pragma warning disable CA1416 // Validate platform compatibility

using (var synthesizer = new SpeechSynthesizer())
{
    try
    {
        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
    }
    catch
    {
        Console.WriteLine("The requested voice is not available. Using default voice.");
    }

    PromptBuilder builder = new PromptBuilder();

    builder.AppendText("Welcome to Kinetic Innovative Work Setup");

    builder.AppendBreak(TimeSpan.FromSeconds(1));

    builder.AppendText(string.Format("Keep in mind while you working"));

    builder.AppendBreak(TimeSpan.FromSeconds(3));

    builder.AppendText(string.Format(@"Don't work for the FAME. Keep Learning. If you really want to be great at something, you have to truly care about it. you have to obsess over it.
          If you don't believe on yourself, no one will do it for you. If you keep pushing, you'll keep getting better. - said by KOBE BRYANT!!"));

    builder.AppendBreak(TimeSpan.FromSeconds(2));

    builder.AppendText("Let's go.");

    synthesizer.Speak(builder);
}

#pragma warning restore CA1416 // Validate platform compatibility


int milliseconds = 3000;

Console.Write("Do you like to start (Y/N)?");

string? start = Console.ReadLine();

if (!string.IsNullOrEmpty(start) &&
    start?.ToUpper() == "Y")
{

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





