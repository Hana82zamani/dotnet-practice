namespace ShapeLibInheritanceAbstract;

public abstract class Shape
{
    public abstract void CalculateArea();
   
}
public class Circle : Shape
{
     public double R ;
    public override void CalculateArea()
    {
      
        double result= R*R*3.14;

        Console.WriteLine(result);
    }
}
public class Rectangle : Shape
{
      public double Width;
       public double  Height;
    public override void CalculateArea()
    {

        double result= Width*Height;

        Console.WriteLine(result);
    }
}
