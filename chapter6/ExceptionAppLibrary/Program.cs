using LibraryLibException;

LibraryCard libraryCard=new();

try
{
    libraryCard.CheckCard();
}
catch(LibraryException ex)
{
    Console.WriteLine(ex.Message);
}