Console.WriteLine("enter a number of day:");
int day =int.Parse(Console.ReadLine()!);
switch(day)
{
 case 1:
 Console.WriteLine("saturday");
 break;
case 2 :
Console.WriteLine("sunday");
break;
case 3: 
Console.WriteLine("monday");
break; 
case 4 :
Console.WriteLine("tuesday");
break;
case 5:
Console.WriteLine("wednesday");
break;
case 6:
Console.WriteLine("thursday");
break;
case 7 :
Console.WriteLine("friday");
break;
default :
Console.WriteLine("invalid day");
break;
}
