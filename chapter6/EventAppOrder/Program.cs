using OrderLibEvent;

Order order =new();

void Order_SendEmail(object?sender,EventArgs e)
{
    Console.WriteLine("Email sent!");
}
void Order_UpdateInventory(object? sender,EventArgs e)
{
    Console.WriteLine("Inventory updated!");
}
void Order_CreatedInvoice(object? sender,EventArgs e)
{
    Console.WriteLine("Invoice created!");
}

order.OrderPlaced += Order_SendEmail;
order.OrderPlaced+=Order_UpdateInventory;
order.OrderPlaced+=Order_CreatedInvoice;

order.PlaceOrder();