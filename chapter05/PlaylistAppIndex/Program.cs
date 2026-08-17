using PlaylistLibIndex;

Playlist playlist =new();

 Song song1 = new()
{
    Title=" Birds of a Feather" ,
    Artist="Billie Eilish"
};
Song song2 = new()
{
    Title="Sailor Song" ,
    Artist=" Gigi Perez"
};
Song song3 = new()
{
    Title="Until I Found You " ,
    Artist=" Stephen Sanchez"
};

playlist.songs.Add(song1);
playlist.songs.Add(song2);
playlist.songs.Add(song3);

Console.WriteLine(playlist[0].Title);
Console.WriteLine(playlist[1].Artist);
Console.WriteLine(playlist[2].Title);