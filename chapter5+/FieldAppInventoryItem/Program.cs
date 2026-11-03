using FieldLibInventoryItem;

InventoryItem Item1 = new()
{
    Name="Laptop",
    code=101,
    Quantity=10

};
InventoryItem Item2 = new()
{
    Name="Phone",
    code=102,
    Quantity=50

};
Console.WriteLine($"Name:{Item1.Name}");
Console.WriteLine($"code:{Item1.code}");
Console.WriteLine($"Quantity:{Item1.Quantity}");
Console.WriteLine($"name store :{InventoryItem.NameStore}");
Console.WriteLine($"date :{Item1.dateTime}");

Console.WriteLine($"Name:{Item2.Name}");
Console.WriteLine($"code:{Item2.code}");
Console.WriteLine($"Quantity:{Item2.Quantity}");
Console.WriteLine($"name store :{InventoryItem.NameStore}");
Console.WriteLine($"date :{Item2.dateTime}");




