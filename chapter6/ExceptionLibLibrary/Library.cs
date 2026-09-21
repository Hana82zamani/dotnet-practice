namespace LibraryLibException;

public class LibraryException: Exception
{
    public LibraryException (string Message): base(Message)
    {
        
    }

}

public class LibraryCard 
{
    public void CheckCard()
    {
          throw new LibraryException("invalid libarary card");
    }
}