using OperatorOverloadingLibPayment;

Payment payment1 = new() { Amount = 250000 };
Payment payment2 = new() { Amount = 180000 };

Console.WriteLine(payment1 > payment2);