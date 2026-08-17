namespace StoreLibRecord;

public record Product(string Name,decimal Price ,string Category);

public class Customer(string Name, string City)
{
    public string name {get; set;}=Name;
    public string city{get; set;}=City;
}
