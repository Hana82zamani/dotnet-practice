using OrderLibEventArgs;

Order order = new()
{
    OrderId = 101
};
OrdersEventArgs ordersEventArgs = new()
{
    TotalPrice = 250.75m
};

void Order_Completed(object? sender,OrdersEventArgs e)
{
    if(sender is not Order order1)return;
   
   Console.WriteLine($"{order1.OrderId} completed,total price is {e.TotalPrice}");


}

order.OrderCompleted+=Order_Completed;
order.Complete(ordersEventArgs);
