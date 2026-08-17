namespace BookLibraryEnum;

public enum BookStatus
{
Available,
Borrowed,
Lost
}

public class Book
{
public string Title ="";
public string Author="";
public BookStatus Status;
}