using PlayerLibInterface;

Song song = new()
{
    Title ="Sailor Song"
};

Book book = new()
{
    Title = "C# Programming"
};

Movie movie = new()
{
    Title = "Avatar"
};
song.Play();
book.Print();
movie.Print();