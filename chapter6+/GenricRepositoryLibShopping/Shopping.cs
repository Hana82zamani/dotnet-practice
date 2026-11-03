namespace GenricRepositoryLibShopping;

public class Product
{
    public int Id;
    public string Name = "";
    public decimal Price;
}
public class Customer
{
    public int Id;
    public string Name = "";
}
public interface IRepository<T>
{
    void Add (T item);

    List<T> GetAll();
}
public class Repository<T> : IRepository<T>
{
    public List<T> items =new();
    
    public void Add(T item)
    {
      items.Add(item);
    }
    public List<T> GetAll()
    {
        return items;
    }
    
}