namespace MediaPlayerLibInheritance;

public class MediaPlayer
{
    public virtual void Play()
    {
        Console.WriteLine(" media played");
    }

}
public class MusicPlayer : MediaPlayer
{
    public override void Play()
    {
       Console.WriteLine("Playing music");
    }
}
public class VideoPlayer : MediaPlayer
{
    public override void Play()
    {
       Console.WriteLine("Playing Video");
    }
}


