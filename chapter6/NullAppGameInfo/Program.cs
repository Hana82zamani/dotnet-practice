using GameInfoLibNull;
string? Developer=null;

string DeveloperResult= Developer?? "Unknown";

string? Genre="Adventure";

string GenreResult=Genre?? "null";

Game game =new("Hana");
if (game.Name is null)
{
   throw new ArgumentNullException("name is null");
}
else
{
    
Console.WriteLine($"Name:{game.Name}");
}

Console.WriteLine($"Deveoper:{DeveloperResult}");
Console.WriteLine($"Genre:{GenreResult}");
