namespace FieldLibInventoryItem;

public class InventoryItem
{ 
    public string Name="";
    public int code;

    public int Quantity;
    public const string NameStore="Hana Store";
    public readonly DateTime dateTime;
    public InventoryItem()
    {
        dateTime=DateTime.Now;
    }

}
