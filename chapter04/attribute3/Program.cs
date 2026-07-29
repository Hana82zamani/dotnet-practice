using System.Runtime.CompilerServices;

static void Log(
    [CallerMemberName] string member = "",
    [CallerLineNumber] int line = 0,
    [CallerFilePath] string path = "")
{
 Console.WriteLine($"metod: {member}");
 Console.WriteLine($"line: {line}");
 Console.WriteLine($"file: {path}");
}

static void Login()
{
    Log();
}

Login();