using System.Diagnostics;

string logPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
    "student.txt");

Console.WriteLine($"Log file: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

Trace.AutoFlush = true;

Trace.WriteLine("student: Hana");
Trace.WriteLine("Age: 22");
Trace.WriteLine("Learning C#");

Trace.Close();