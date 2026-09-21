namespace VideoLibDefaultInterface;

public interface IPlayable
{
void Play();

void Pause()
{
    Console.WriteLine("Paused by default");
}
}

public class Video : IPlayable 
{
   public void Play()
    {
        Console.WriteLine("Video is playing");
    }
    public void Pause()
    {
        Console.WriteLine("Video is paused");
    }


}
