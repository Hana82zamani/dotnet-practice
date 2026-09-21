namespace GameInfoLibNull;

public class Game
{
   public string Name  ="";
   public string? Developer ;

   public string? Genre ;

   public Game(string name)
    {
       Name=name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Developer : {Developer}");
        Console.WriteLine($"Genre: {Genre}");
    }
}     
