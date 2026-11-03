  using EventsLibProduct;

    Product product = new()
    {
        name="Laptop"
    };
   static void Message(object? sender, EventArgs e)
    {
       if (sender is not Product p) return;

        Console.WriteLine($"{p.name} price changed");
    }


    product.PriceChanged+=Message;

    product.ChangePrice(100m);
    product.ChangePrice(100m);
    product.ChangePrice(200m);