
namespace IComparabeIComparerLib;

public class Product: IComparable<Product>
{  
public int Id { get; set; }
public string name{get;set;}="";
public decimal price{get;set;}
public int balance{get;set;}

public int CompareTo(Product? other)
    {
        if (other is null)return 1;

        return price.CompareTo(other.price);
    }

}

public class ProductStockComparer : IComparer<Product>
{
    public int Compare(Product? x,Product? y)
    {
        if (x is null)return y is null? 0 : 1 ;
        if (y is null) return -1;

        return x.balance.CompareTo(y.balance);
    }
}


