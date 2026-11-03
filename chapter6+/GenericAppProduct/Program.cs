using GenricLibProduct;


 Dictionary<int, Product> products=new();

products.Add(101,new Product
{ Name="Laptop",
  Price=1000
}
);

products.Add(102,new Product
{ Name="Mouse",
  Price=100
}
);

products.Add(103,new Product
{ Name="keybord",
  Price=500
}
);
Console.WriteLine($"{products[102].Name}={products[102].Price}");
