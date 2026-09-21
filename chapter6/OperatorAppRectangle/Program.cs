using RectangleLibOperator;

Rectangle rectangle1 = new()
{
    Width=10,
    Height=5
    
};
Rectangle rectangle2 = new()
{
    Width=20,
    Height=3
    
};

Rectangle result=rectangle1+rectangle2;
Console.WriteLine($"height:{result.Height}, width: {result.Width}");

Rectangle result2 = Rectangle.Add(rectangle1, rectangle2);
Console.WriteLine($"height:{result2.Height}, width:{result2.Width}");
