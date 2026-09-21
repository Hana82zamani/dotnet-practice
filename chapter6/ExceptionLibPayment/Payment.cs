namespace PaymentLibException;

// استفاده کرد excepthion برای نوشتن  constructor میشود از س مدل 

public class PaymentException:Exception
{
    public PaymentException() : base() //  بدون اطلاعات constructor 
    {
    }
    public PaymentException(string message):base (message) // با پیام constructor
    {

    }
    public PaymentException(string message, Exception innerException) // پیام و خطا قبلی constructor
    : base(message, innerException)
    {
    }

}
public class PaymentProcessor
{
   public void Process()
    {
        throw new PaymentException("invalid");

    }

}