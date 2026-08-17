using PhoneLib;

Phone phone = new()
{
    Brand= "Xiaomi",

    Model="Redmi15",

};
Phone.OperatingSystem="Android";

Console.WriteLine($"brand: {phone.Brand}");
Console.WriteLine($"Model:{phone.Model}");
Console.WriteLine($"System:{Phone.OperatingSystem}");
Console.WriteLine($"Contry:{Phone.Country}");
Console.WriteLine($"serialnumber:{phone.SerialNumber}");
