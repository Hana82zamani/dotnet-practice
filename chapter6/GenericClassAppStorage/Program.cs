using StorageLibGenericClass;

Storage<int>storage1=new();
storage1.Value=100;

Storage<string>storage2=new();
storage2.Value="Hana";

Storage<double>storage3=new();
storage3.Value= 15.5;

Console.WriteLine($"{storage1.Value}");
Console.WriteLine($"{storage2.Value}");
Console.WriteLine($"{storage3.Value}");