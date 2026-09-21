using BookLibThis;

Book book1 = new()
{
    Title = "C#",
    Price = 800
};

Console.WriteLine($"{book1.Title}: {book1.GetPrice()}");
