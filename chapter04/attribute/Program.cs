using System.Runtime.CompilerServices;
static void ShowCaller(
    [CallerMemberName] string member = "")
{
    Console.WriteLine($"Called from: {member}");
}
ShowCaller();