
using LibraryLib;

Book book1 = new()
{
    Title = "C# Basics",
    Author = "Hana",
    Pages = 200
};


Book book2 = new("OOP in C#", "Mark");

Console.WriteLine($"{book1.Title}");
Console.WriteLine($"{book1.Author}");
Console.WriteLine($"{book1.Pages}");
Console.WriteLine($"{book2.Title}");
Console.WriteLine($"{book2.Author}");