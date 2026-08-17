using System.Diagnostics.CodeAnalysis;

namespace LibraryLib;

public class Book
{
    public required string Title;
    public required string Author;

    public int Pages;

    public Book()
    {
    }
     [SetsRequiredMembers ]
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}
