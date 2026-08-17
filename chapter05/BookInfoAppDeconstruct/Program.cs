using BookInfoLibDeconstruct;

Book book=new();

var (title,pages)=book;

Console.WriteLine($"{title},{pages}");