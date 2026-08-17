using UserLibPrprerty;

User user=new();

try
{
     user.Username="";
 
    Console.WriteLine(user.Username);
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}