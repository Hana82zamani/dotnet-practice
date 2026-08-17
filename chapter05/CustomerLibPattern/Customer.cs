namespace CustomerLibPattern;
public class Customer
{
    public string Name { get; set; } = "";
}

public class StudentCustomer : Customer
{
    public int Age { get; set; }
}

public class RegularCustomer : Customer
{
    public int PurchaseCount { get; set; }
}

