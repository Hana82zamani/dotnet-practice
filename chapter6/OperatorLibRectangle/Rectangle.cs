namespace RectangleLibOperator;

public class Rectangle
{
  public int Width{get;set;}
  public int Height{get;set;}

    public static Rectangle Add(Rectangle rectangle1,Rectangle rectangle2)
    {
        return new Rectangle
        {
            Width = rectangle1.Width + rectangle2.Width,
           Height = rectangle1.Height + rectangle2.Height
        };
    }

    public static Rectangle operator+(Rectangle rectangle1,Rectangle rectangle2)
    {
        return Add(rectangle1,rectangle2);
        
        
    }


}
