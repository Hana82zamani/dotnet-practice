
using SongLibrary;

Song song1 = new()
{
    Title="Sailor song",
    Artist="Gigi perez"
};

Song song2 = new()
{
    Title="call me senorita",
    Artist="Shawn Mendes"
};


Song song3 = new()
{
    Title="TQG",
    Artist="Shakira"
};

Playlist playlist = new()
{
    Name="favorit songs",

    Genre=MusicGenre.Pop

};

playlist.songs.Add(song1);
playlist.songs.Add(song2);
playlist.songs.Add(song3);

Console.WriteLine($"{playlist.Name}");

Console.WriteLine($"gener:{playlist.Genre}");


foreach(Song song in playlist.songs)
{
    Console.WriteLine($"{song.Title}-{song.Artist}");
}