namespace GenricLibPrint;

public  class Product 
{
   public int Id ;
   public string Name = "";
   public decimal Price;


public void PrintItem<T>(T item)
{
    Console.WriteLine(item);
}

}
