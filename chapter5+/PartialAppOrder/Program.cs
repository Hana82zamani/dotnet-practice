using PartialLibOrder;

Order order = new()
{
    OrderId=101,
    CustomerName="Hana",
    Amount=100
};
Console.WriteLine($"Tax amount:{order.CalculateTax()}");

Console.WriteLine($"Total amount:{order.GetFinalAmount()}");