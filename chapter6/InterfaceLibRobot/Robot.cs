namespace RobotLibInterface;

public interface IMovable
{
  void Move();
    
}
public interface ISpeakable
{
  void Speak();

}
public class Robot : IMovable , ISpeakable
{
   public void Move()
    {
        Console.WriteLine("Robot is moving");
    }
    public void Speak()
    {
        Console.WriteLine("Robot is speaking");
    }

}
