
using System.Diagnostics;

string logPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
    "profile.txt");

Console.WriteLine($"Log file: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

Trace.AutoFlush = true;

Console.WriteLine("enter you name:");
string name=Console.ReadLine()!;

Console.WriteLine("enter you major:");
string major=Console.ReadLine()!;


Console.WriteLine("enter your age:");
int age = int.Parse(Console.ReadLine()!);
if (age < 0)
{
    Trace.WriteLine("Invalid age");
}
else
{

Trace.WriteLine($"student:{name}");
Trace.WriteLine($"Age:{age}");
Trace.WriteLine($"major:{major}");
}
Trace.Close();
