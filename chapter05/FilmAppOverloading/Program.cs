using FilmLibOverloading;

Film film = new()
{
    Title = "Friends",
    Year = 1990
};

film.ShowInfo();

Console.WriteLine(
    film.ShowInfo("My favorite film is this.")
);

Console.WriteLine(
    film.RateMovie()
);

Console.WriteLine(
    film.RateMovie(10)
);