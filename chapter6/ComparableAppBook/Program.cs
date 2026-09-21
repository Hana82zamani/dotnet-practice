using BookLibComparable;

Book[] books =
{
    new Book
    {
        Title="C# Basics",
        Pages=300
    },
    new Book
    {
        Title="Algorithms ",
        Pages=200
    },
    new Book
    {
        Title="Clean Code",
        Pages=300
    },
    new Book
    {
        Title="Math",
        Pages=200
    }
};
Array.Sort(books);

foreach (Book book in books)
{
    Console.WriteLine(book.Title);
}