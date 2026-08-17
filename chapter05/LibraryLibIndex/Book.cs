namespace LibraryLibIndex;

public class Library
{
  public List<string> Books = new();

  public string this[int index]
   {
    get { return Books [index]; }

    set{ Books[index]=value;}
   }
}


