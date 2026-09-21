using productLibGeneric;

Dictionary<int,Product>Products=new();

Products.Add(1,new(){Name="Laptop", Price=1500});

Products.Add(2,new(){Name="Phone", Price=800});

Products.Add(3,new(){Name="Mouse", Price=50});

Console.WriteLine(Products[2].Price);