using LaptopLibRview;

Laptop laptop1=new("Asus",16,1200);
var(brand1,ram1,price1)=laptop1;

Laptop laptop2=new("Lenovo",8,700);
var(brand2,ram2,price2)=laptop2;

Laptop laptop3=new("Apple",32,2500);
var(brand3,ram3,price3)=laptop3;

Laptop[] laptops =
{
    laptop1,
    laptop2,
    laptop3
    
};


Laptop newlaptop= laptop2 with
    {
        Ram=16
    };
    foreach(Laptop laptop in laptops)
{
    
        string status= laptop switch
    {
    Laptop{Ram : >= 32 ,Price: >= 2000}=>"ultra",
    Laptop{Ram:>=16, Price:>=1000}=> "pro",
    _ => "normal"

    };
    Console.WriteLine($"{laptop.Brand}: {status}");
        
}
    
        string newstatus= newlaptop switch
        {
        Laptop{Ram : >= 32 ,Price: >= 2000}=>"ultra",
        Laptop{Ram:>=16, Price:>=1000}=> "pro",
    _ => "normal"
        };
Console.WriteLine($"{newlaptop.Brand} updated :{newstatus}");
 

 
 
