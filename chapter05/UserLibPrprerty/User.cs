namespace UserLibPrprerty;

public class User
{
private string username;

 public string Username
    {
        get
        {
            return username;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("enter username");
            }
            
            username=value;
        }
    
    }

}
