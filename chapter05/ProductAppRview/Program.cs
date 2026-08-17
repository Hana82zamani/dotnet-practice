using ProductLibRview;

Product [] products =
{
    
new PhysicalProduct
{
   Name= "Laptop",
  Price = 1500,
  Weight = 2,
  Stock = 10,
  Supplier= new SupplierInfo("Apple","@Apple.gmial")
},

new PhysicalProduct
{
 Name= "Phone",
Price = 700,
Weight = 0.5,
Stock = 3,
Supplier= new SupplierInfo("Apple","@Apple.gmial")
},

new DigitalProduct
{
Name="C# Course",
Price = 300,
FileSize = 1500,
Downloads = 200,
Supplier= new SupplierInfo("Apple","@Apple.gmial")

},

new DigitalProduct
{
Name= "Design Course",
Price = 800,
FileSize = 3000,
Downloads = 50,
Supplier= new SupplierInfo("Apple","@Apple.gmial")
}

};
foreach (Product product in products)
{
    string status = product switch
    {
        PhysicalProduct {Price:>= 1000,Stock: >= 5}=> "Premium Physical",

      PhysicalProduct=> "Normal Physical",

       DigitalProduct {Price: >= 500,Downloads: >= 100}=>"Popular Digital",

       DigitalProduct => "Normal Digital",

       _ => "unknown"
    };
    Console.WriteLine ($"{product.Name} : {status}");
}

SupplierInfo newsupplier =products[2].Supplier with{

    Email="@ApplePro.gmial"

};
Console.WriteLine($"new email: {newsupplier.Email}");

Console.WriteLine(products[0].Supplier);