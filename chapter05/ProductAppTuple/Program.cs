using ProductLib2;

Product product=new();

var(name,price)=product.GetProductInfo();

Console.WriteLine($"name:{name},price:{price}");