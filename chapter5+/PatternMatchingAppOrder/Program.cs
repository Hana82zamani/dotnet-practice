using PatternMatchingLibOrder;

Order order = new()
{
    TotalPrice=10000,
    IsPremiumCustomer=true
};

decimal OrderPrice= order switch 
{
Order{ IsPremiumCustomer:true , TotalPrice:>5000}=>
order.TotalPrice-(order.TotalPrice*0.20m),
Order{ IsPremiumCustomer:true , TotalPrice:<=5000}=>
order.TotalPrice-(order.TotalPrice*0.10m),
Order{ IsPremiumCustomer:false}=>OrderPrice=order.TotalPrice,
    _ =>0
    
};

Console.WriteLine($"premium customer :{order.IsPremiumCustomer}={OrderPrice}");