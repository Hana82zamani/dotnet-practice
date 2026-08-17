using BookLibraryEnum;

Book book= new()
{
 Title= "C# Programming" ,
Author=" John",

Status= BookStatus.Borrowed 

};
Console.WriteLine($"title:{book.Title}");

Console.WriteLine($"Author:{book.Author}");

Console.WriteLine($"status:{book.Status}");

Console.WriteLine($"Number: {(int)book.Status}");