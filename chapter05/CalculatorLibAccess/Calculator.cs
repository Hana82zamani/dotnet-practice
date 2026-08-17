namespace CaculatorLibAccess;

public class Caculator
{
 public int Add(int a, int b)
    {
        return a+b;
    }
    public int Add(int x)
    {
        return x;
    }

    public int Multiply(int a , int b)
    {
        return a*b;
    }

    public double Power(int a , int b=2)
    {
         return Math.Pow(a, b);
    }


}
