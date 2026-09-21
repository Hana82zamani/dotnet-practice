namespace ReviewLibProduct;

public interface IStorage<T>
{
    void Add(T item);
    void ShowAll();
}
public class Product 
{
   public string Name="";
   public decimal Price;

}
public class ProductStorage :IStorage<Product>
{
    private List<Product> products = new();

    public void Add(Product item)
    {
        products.Add(item); 
    }
    public void ShowAll()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.Name} = {product.Price}");
        }
        
    }

}

public class Customer
{
   public string Name="";
   public int Age;
}
public class CustomerStorage : IStorage<Customer>
{
    private List<Customer> customers=new();

    public void Add(Customer item)
    {
        customers.Add(item);
    }

    public void ShowAll()
    {
        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.Name}= {customer.Age}");
        }
    }

}