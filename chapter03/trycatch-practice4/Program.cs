double ave=0;
Console.Write("enter first nuber:");
string num1=Console.ReadLine()!;
Console.Write("enter the second nuber:");
string num2=Console.ReadLine()!;
Console.Write("enter the third nuber:");
string num3=Console.ReadLine()!;
Console.Write("enter the fourth nuber:");
string num4=Console.ReadLine()!;
Console.Write("enter the fifth nuber:");
string num5=Console.ReadLine()!;
 
try
{
 int n1=int.Parse(num1);
 int n2=int.Parse(num2);
 int n3=int.Parse(num3);
 int n4=int.Parse(num4);
 int n5=int.Parse(num5);

ave=(double)(n1+n2+n3+n4+n5)/5;
Console.WriteLine($"average={ave}");
int max=n1;
int min=n1;

    if (max < n1)
    {
        max=n1;
      
    }
    if (max < n2)
    {
        max=n2;
        
    }
    if (max < n3)
    {
        max=n3;
        
    } 
    if (max < n4)
    {
        max=n4;

    }
     if (max < n5)
    {
        max=n5;
      
    }
      Console.WriteLine($"max={max}");

if (min > n1)
    {
        min=n1;
       
    }
     if (min > n2)
    {
        min=n2;
       
    } 
    if (min > n3)
    {
        min=n3;
     
    } 
    if (min > n4)
    {
        min=n4;
    } 
    if (min > n5)
    {
        min=n5;
  
    }
     Console.WriteLine($"min={min}");
}


catch
{
    Console.WriteLine("Invalid! enter numbers:");
    
}