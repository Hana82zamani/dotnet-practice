namespace IndexLibHotel;

public class Hotel
{
    private List<int> Rooms=new()
    {
        101,
        102,
        103,
        104
    };

    public int this[int index]
    {
        get { return Rooms[index];}
  
    }
    

}
