using IComparabeIComparerLib;


Product[] products=
    {
        new(){Id=1, name="mouse",price=800,balance=12},
        new(){Id=2, name="keyboard",price=1500,balance=5},
        new(){Id=3, name="monitor",price=8000,balance=20},
        new(){Id=4, name="headset",price=2000,balance=3},

    };
    Array.Sort(products);

Array.Sort(products, new ProductStockComparer());

foreach (Product product in products)
{
    Console.WriteLine(
        $"{product.name} | Price: {product.price} | Stock: {product.balance}");
}