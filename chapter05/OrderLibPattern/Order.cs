namespace OrderLibPattern;

public class Order
{
 public string id{get; set;}="";
}
public class FoodOrder: Order
{
  public decimal TotalPrice{get; set;}
public int  ItemCount{get; set;}
} 
public class ElectronicOrder: Order
{
  public decimal TotalPrice{get; set;}
public int  WarrantyMonths{get; set;}
} 
public class ClothingOrder: Order
{
  public decimal TotalPrice{get; set;}
public int ItemCount {get; set;}
} 
