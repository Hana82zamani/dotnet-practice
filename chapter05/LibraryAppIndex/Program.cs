using LibraryLibIndex;

Library library =new();

library.Books.Add("C#");
library.Books.Add("Java");
library.Books.Add("Python");

Console.WriteLine(library[0]);
Console.WriteLine(library[1]);
Console.WriteLine(library[2]);