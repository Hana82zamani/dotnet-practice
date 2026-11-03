using DictionaryGenericsLibOrder;

Order order=new();

order.Orders.Add(101,"Hana");

order.Orders.Add(102,"Ali");

order.Orders.Add(103,"Sara");

Console.WriteLine(order.Orders[102]);
