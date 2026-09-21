namespace ContainerLibGeneric;

public class Container<T>
{
 public T Value;
public void ShowValue()
{
    Console.WriteLine($"Value: {Value}");
}
}
// T و استفاده از generic class تمرین 