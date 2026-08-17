using StoreLibRecord;

Product product=new("laptop",1500,"electronics");

var (name,price,category)=product;

Console.WriteLine(name);
Console.WriteLine(price);
Console.WriteLine(category);

Product newproduct = product with
{
    Price=1800
};

Console.WriteLine($"original price:{price}");
Console.WriteLine($"new price {newproduct.Price}");

Customer customer=new("Hana","Tehran");

Console.WriteLine(customer.name);
Console.WriteLine(customer.city);

