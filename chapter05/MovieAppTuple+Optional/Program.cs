using MovieLib2;

Movie movie=new();

var(Title,Year,Rating)=movie.GetMovieInfo();

Console.WriteLine($"Title:{Title},Year{Year},Rate:{Rating}");