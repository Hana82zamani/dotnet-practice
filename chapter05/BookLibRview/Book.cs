namespace BookLibRview;

public class Book
{
 public string Title{get;set;}="";
public decimal Price{get;set;}
}
public class PrintedBook: Book
{
    public int Pages{get;set;}
}
public class EBook: Book
{
    public int FileSizeMB{get;set;}
}
public class Library
{
    public List<Book> Books =new();
    
    public Book this[int index]
    {
        get
        {
            return Books [index] ;
        }
    }
  
}
