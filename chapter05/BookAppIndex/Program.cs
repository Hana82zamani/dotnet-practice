using BookLibIndex;

Book book = new();


Library book1 = new()
{
    Title="Shahname",
    Author="Ferdosi"
};
Library book2 = new()
{
    Title="Golestan",
    Author="Saadi"
};
Library book3 = new()
{
    Title="Masnavi",
    Author="Molana"
};

book.Books.Add(book1);
book.Books.Add(book2);
book.Books.Add(book3);

Console.WriteLine(book[0].Title);

Console.WriteLine(book[0].Author);