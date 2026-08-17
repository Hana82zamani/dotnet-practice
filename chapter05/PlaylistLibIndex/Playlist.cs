namespace PlaylistLibIndex;

public class Song
{
    public string Title="";
    public string Artist="";

}
public class Playlist
{
    public List<Song>songs=new();

    public Song this[int index]
    {
        get
        {
            return songs [index];
        }
    }
}
