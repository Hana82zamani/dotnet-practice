namespace BookLibThis;

public class Book
{
  public string Title="";
public double Price;

public static double GetPrice(Book book)
    {
        return book.Price;
    }

    public double GetPrice()
    {
        return GetPrice(this);
    }

}
