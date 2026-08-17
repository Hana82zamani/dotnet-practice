namespace BookInfoLibDeconstruct;

public class Book
{
 
 public string Title = "C# Basics";
public int Pages = 200;

public void Deconstruct(out string title,out int pages)
    {
        title=Title;
        pages=Pages;
    }


}



