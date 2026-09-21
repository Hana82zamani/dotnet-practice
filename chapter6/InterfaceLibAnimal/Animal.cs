namespace AnimalibInterface;


public interface IAnimal
{
    void MakeSound();
}
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }

}
