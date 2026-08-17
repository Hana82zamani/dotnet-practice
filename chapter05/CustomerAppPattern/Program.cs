using CustomerLibPattern;

Customer[] customers =
{
    new StudentCustomer { Name = "Hana", Age = 16 },
    new StudentCustomer { Name = "Ali", Age = 22 },
    new RegularCustomer { Name = "Sara", PurchaseCount = 15 },
    new RegularCustomer { Name = "Mina", PurchaseCount = 3 }
};
foreach (Customer customer in customers)
{
    int discount = customer switch
    {
     StudentCustomer s when s.Age <18 => 20,
     StudentCustomer s when s.Age>=18=> 10,
     RegularCustomer r when r.PurchaseCount >10 => 15,
     RegularCustomer r when r.PurchaseCount <= 10 => 5,
     _ => 0

    };

    Console.WriteLine($"{customer.Name}: {discount}%");
}  