using GenericLibPayment;

PaymentResult<int> paymentResult1=new(501);

PaymentResult<string> paymentResult2=new("Payment successful");

Console.WriteLine(paymentResult1.Data);

Console.WriteLine(paymentResult2.Data);
