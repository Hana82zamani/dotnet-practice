namespace SongLibInterfaceDefult;

public interface IPlayable
{
   void Play();
   void Pause()
    {
        Console.WriteLine("Paused by default");
    }
}

public class Song:IPlayable 
{
    public void Play()
    {
        Console.WriteLine("Sailor Song is playing");
    }



}
