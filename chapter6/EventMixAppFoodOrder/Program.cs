using FoodOrderLibEventMix;

FoodOrder foodOrder1 = new()
{
    RestaurantName = "Pizza House"

};
OrderEventArgs orderEventArgs1 = new()
{
    OrderNumber = 101,
     FoodName = "Pepperoni Pizza"
};
FoodOrder foodOrder2 = new()
{
    RestaurantName = "Burger Land"

};
OrderEventArgs orderEventArgs2 = new()
{
    OrderNumber = 202,
    FoodName = "Cheeseburger"
};
void OrderReady_Message(object?sender, OrderEventArgs e)
{
    if (sender is not FoodOrder order)return;
  Console.WriteLine($"{order.RestaurantName}:{e.OrderNumber} {e.FoodName} is ready");

}
void OrderReady_Log(object?sender,OrderEventArgs e)
{
     if (sender is not FoodOrder order)return;
     Console.WriteLine("Order logged!");
}

foodOrder1.OrderReady+=OrderReady_Message;
foodOrder1.OrderReady+=OrderReady_Log;

foodOrder2.OrderReady+=OrderReady_Message;
foodOrder2.OrderReady+=OrderReady_Log;

foodOrder2.OrderReady-=OrderReady_Log;

foodOrder1.PrepareOrder(orderEventArgs1);
foodOrder2.PrepareOrder(orderEventArgs2);
