namespace GenericConstraintsLibCustomer;

public class Customer
{
    public string Name { get; set; } = "";

} 
public class Product
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}
public class StoreRepository<T> where T : class
{
    public T Item{get;set;}

    public StoreRepository(T item)
    {
        Item=item;
    }
  
}


