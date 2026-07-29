using System.Runtime.CompilerServices;

static void ErrorLog(
    string message,

    [CallerMemberName] string member = "",
    [CallerLineNumber] int line = 0,
    [CallerFilePath] string path = "")

{
  Console.WriteLine($"[error]");
  Console.WriteLine($"message :{message}");
  Console.WriteLine($"method:{member}");
  Console.WriteLine($"line:{line}");
  Console.WriteLine($"file:{path}");
}
 
 static void Login()
{
    ErrorLog("Invalid message");
}
Login();