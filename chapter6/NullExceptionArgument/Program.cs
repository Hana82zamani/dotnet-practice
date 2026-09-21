
static void ShowTitle(string? title)
{
   
        throw new ArgumentNullException(title);
   
        Console.WriteLine($"Title : {title}");
    
}
ShowTitle("C# Programming");
ShowTitle(null);