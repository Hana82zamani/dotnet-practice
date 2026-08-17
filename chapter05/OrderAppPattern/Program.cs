using OrderLibPattern;

Order[] orders =
{
   new FoodOrder
   {
       TotalPrice = 800,
       ItemCount = 6

   },
   new FoodOrder
   {
       TotalPrice = 300,
       ItemCount = 2
   },
   new ElectronicOrder
   {
       TotalPrice = 5000,
       WarrantyMonths = 24

   },
   new ElectronicOrder
   {
       TotalPrice = 2000,
       WarrantyMonths = 6

   },
   new ClothingOrder
   {
       TotalPrice = 1500,
       ItemCount = 4

   },

};
foreach (Order order in orders)
{
    string status = order switch
    {
        FoodOrder{TotalPrice: >= 500 ,ItemCount: >= 5}=>"VIP food",
        FoodOrder => "normal food",
        ElectronicOrder {TotalPrice: >= 4000 ,WarrantyMonths: >= 12}=>"permum order",
        ElectronicOrder => "normal order",
        ClothingOrder{ItemCount: >= 4}=>"Bulk cloth",
        ClothingOrder=> "normal cloth",
        _ => "unknown"
    };
    Console.WriteLine($" {status}");

}
