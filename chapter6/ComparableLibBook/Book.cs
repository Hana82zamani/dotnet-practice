namespace BookLibComparable;

public class Book : IComparable<Book>
{
   public string Title="";
   public int Pages;

   public int CompareTo(Book? other)
    {
        if(other is null)return 1;

        int result= Pages.CompareTo(other.Pages);

        if(result == 0)
        {
           return Title.CompareTo(other.Title);
        }
        return result;

    }


}
