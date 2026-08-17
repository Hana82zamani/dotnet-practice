namespace foodLibraryEnum;

[Flags]
public enum Extra : byte
{
Cheese=0,
Sauce=1,
Mushroom=2,
Olives=4
}

public enum FastFood
{
Pizza,
Burger,
Pasta,
Salad,
}

public class FoodOrder
{
 public string CustomerName="";

public FastFood Food ;

public Extra Extra;

}
