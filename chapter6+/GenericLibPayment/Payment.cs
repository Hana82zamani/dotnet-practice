namespace GenericLibPayment;

public class PaymentResult<T>
{
 public T Data{get;set;}

 public PaymentResult(T data)
    {
        Data=data;
    }
    

}


