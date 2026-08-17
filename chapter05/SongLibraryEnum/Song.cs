namespace SongLibrary;
public enum MusicGenre
{
Pop,
Rock,
Jazz,
Classical,
}
public class Song
{
public string Title="";

public string Artist="";

}

public class Playlist
{
 public string Name="";

public MusicGenre Genre;

public List<Song> songs=new();
}
