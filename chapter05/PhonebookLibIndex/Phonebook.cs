namespace PhonebookIndex;

  public class Contact
{
    public string Name = "";
    public string Number = "";
}
public class Phonebook
{

   public List<Contact>Contacts=new();

   public Contact this [string name]
    {
        get
        { 
            return Contacts.Find(P=> P.Name==name);
        }
       
    }


}