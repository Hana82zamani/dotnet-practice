namespace ProductLibRview;

public class Product
{
  public string Name{get; set;}="";
  public int Price{get; set;}

  public SupplierInfo  Supplier{get; set;}
}
public class PhysicalProduct : Product
{
   public double Weight;
   public int Stock;

}
public class DigitalProduct : Product
{
  public int FileSize;
public int Downloads;
}
 public record SupplierInfo(string Company , string Email);
 
 public class Store
{
  public List<Product>products=new();

  public Product this[int index]
  {
    get
    {
      return products[index];
    }
  }
  
}
