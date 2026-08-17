using BookLibRview;

Library library=new();

Book[] books=
{
    
    new PrintedBook
    {
    
      Title="C# Basics",
      Price = 500, 
      Pages = 300
    },
      
    new PrintedBook
    {
        Title="Clean Code",
        Price = 900,
        Pages = 450
    },
    new EBook
    {
        
       Title="C# Advanced",
       Price = 400,
       FileSizeMB = 20
    },
    new EBook
    {
        Title="Design Patterns",
        Price = 1000,
        FileSizeMB = 80
    },
    new EBook
    {
       Title="Algorithms",
       Price = 700,
       FileSizeMB = 50

    }

    
};
foreach(Book book in books)
{
    string status= book switch
    {
        PrintedBook{Pages:>400, Price:>800}=>"Premium Printed",
        PrintedBook=> "Normal Printed",
        EBook{Price:>800,FileSizeMB:>50}=> "Premium Ebook",
        EBook=> "Normal Ebook",
        _ => "unknown"

    };

    library.Books.Add(book);
} 
Console.WriteLine(library[0].Title);