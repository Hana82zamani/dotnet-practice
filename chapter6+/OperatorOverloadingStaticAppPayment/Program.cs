using OperatorOverloadingStaticLibPayment;

Payment payment1=new(){Amount=300000};

Payment payment2=new(){Amount=250000};

Console.WriteLine
(Payment.IsGreater(new Payment{Amount=300000},new Payment{Amount=250000}));

Console.WriteLine(payment1>payment2);

Console.WriteLine(payment1<payment2);