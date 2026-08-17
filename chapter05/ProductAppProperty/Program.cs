using ProductLibProperty;

Product product = new();

product.Price = 1000;
try
{

    Console.WriteLine(product.Price);

    Console.WriteLine(product.DiscountedPrice);

}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}


