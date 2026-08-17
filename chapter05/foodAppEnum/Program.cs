using foodLibraryEnum;

FoodOrder order = new()
{
   CustomerName ="Hana",
     Food = FastFood.Pizza,
     Extra = Extra.Cheese | Extra.Mushroom
     
};
Console.WriteLine($"Name:{order.CustomerName}");

Console.WriteLine($"{order.Food}");

Console.WriteLine($"{order.Extra}");

Console.WriteLine($"{(int)order.Extra}");


if (order.Extra.HasFlag(Extra.Cheese))
{
    Console.WriteLine("has cheese");
}
if (order.Extra.HasFlag(Extra.Mushroom))
{
    Console.WriteLine("has mushroom");
}
if (order.Extra.HasFlag(Extra.Olives))
{
    Console.WriteLine("has olives");
}