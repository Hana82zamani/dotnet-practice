namespace CameraLibExplicitImplicit;

public interface IPlayable
{
    void Play();
}
public interface IRecordable
{
    void Record();
}
public class Camera : IPlayable,IRecordable
{
    public void Play()
    {
        Console.WriteLine("Camera is playing");
    }
    void IRecordable.Record()
    {
        Console.WriteLine("Camera is recording");
    }

};




