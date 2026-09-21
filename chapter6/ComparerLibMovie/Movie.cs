namespace MovieLibComparer;

public class Movie
{
    public string Title = "";
    public int Duration;

}

public class MovieComparer: IComparer<Movie>
{
    public int Compare(Movie? x, Movie? y)
    {
        if(x is null)return-1;
        if(y is null)return 1;

        int result = x.Duration.CompareTo(y.Duration);

        if (result == 0)
        {
            return x.Title.CompareTo(y.Title);
        }

        return result;
        
    
    }

}
