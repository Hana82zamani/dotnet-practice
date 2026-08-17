namespace CreateAccountLibDeconstruct;

public class Account 
{
 public string CreateAccount(string username, int age, string country="Iran", bool active= true)
    {
        return $"user name :{username} age:{age} country:{country} active:{active}";
    }
}
