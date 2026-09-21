
Vector v1 = new(10, 4);

Vector v2 = new(3, -2);

Vector v3 = v1 + v2;

Console.WriteLine($"({v3.X}, {v3.Y})");
public struct Vector
{
    public int X;
    public int Y;

    public Vector(int x, int y)
    {
        X=x;
        Y=y;
    
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }
}