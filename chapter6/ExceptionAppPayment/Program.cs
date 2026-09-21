using PaymentLibException;

PaymentProcessor paymentProcessor = new();

try
{
    paymentProcessor.Process();
}
catch(PaymentException ex)
{
    Console.WriteLine(ex.Message);
}
