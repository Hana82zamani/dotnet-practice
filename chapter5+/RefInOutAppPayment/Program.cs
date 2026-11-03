using RefInOutLibPayment;

Payment payment = new();

decimal amount=100;

Console.WriteLine($"Before: {amount}");

payment.plus(ref amount);
Console.WriteLine($"amount plus 10 peresent: {amount}");

  decimal TaxAmount;
  decimal TotalAmount;
payment.Tax(amount ,out TaxAmount,out TotalAmount);
Console.WriteLine($"amount tax:{TaxAmount},total amount:{TotalAmount}");


payment.Show(in amount);
