using PermissionLibFlag;

Permission permission= Permission.Read | Permission.Write;

if ((Permission.Read & permission )!=0)
{
    Console.WriteLine("can read");
}