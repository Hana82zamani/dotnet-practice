namespace MovieLib2;

public class Movie
{
    public (string Title, int Year, double Rating)GetMovieInfo(string Title ="Friends",int Year=1994,double Rating = 8.5)
    {
        return(Title,Year,Rating);
    }

}
