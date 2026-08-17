namespace MovieInfoLib;

public class Movie
{
public string Title="Friends";
public int Year=1994;
public int Rating= 8;

public void Deconstruct(out string title,out int year, out int rating)
    {
        title=Title;
        year=Year;
        rating=Rating;
        
    }

}
