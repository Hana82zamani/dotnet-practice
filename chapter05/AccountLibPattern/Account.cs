namespace AccountLibPattern;

public class Account
{
public string Username{get; set;}="";
}
public class FreeAccount : Account
{
  public int DaysActive{get; set;}
}
public class PremiumAccount: Account
{
 
  public int DaysActive{get; set;}

  public int Downloads{get; set;}
}
public class BusinessAccount : Account
{
  
  public int Employee{get; set;}

  public int StorageGB{get; set;}
}

