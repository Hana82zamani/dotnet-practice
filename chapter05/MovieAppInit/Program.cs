using MovieLibInit;

Movie movie = new()
{
    Title="Interstellar",
    Director="Christopher Nolan",
    Year= 2014
};

Console.WriteLine(movie.Title);
Console.WriteLine(movie.Director);
Console.WriteLine(movie.Year);