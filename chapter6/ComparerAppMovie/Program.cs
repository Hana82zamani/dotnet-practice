using MovieLibComparer;

Movie[] movies =
{
    new Movie
    {
        Title="Avatar",
        Duration= 180   
    },
    new Movie
    {
        Title="Titanic",
        Duration=180
    },
    new Movie
    {
        Title="Cars",
        Duration=100
    },
};
Array.Sort(movies,new MovieComparer());

foreach (Movie movie in movies)
{
    Console.WriteLine(movie.Title);
}
