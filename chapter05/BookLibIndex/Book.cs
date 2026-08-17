namespace BookLibIndex;

public class Library
{
 public string Title="";
 public string Author="";

};
public class Book{

 public List<Library>Books=new();

 public Library this[int index]
    {
        get
        {
            return Books [index] ;
        }
        
    }
}

