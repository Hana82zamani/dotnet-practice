using System.Runtime.CompilerServices;

class Program
{
    
static void PrintMassage(

    [CallerMemberName] string member ="")
{
    Console.WriteLine($"Method {member} called PrintMessage");
}

static void Login()
{
 PrintMassage();   
}

static void Logout()
{
    PrintMassage();
    
}

static void Main()
{
Login();
Logout();
}
}
// caller metod practice