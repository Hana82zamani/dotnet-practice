namespace PropertyIndexLibHotel;

public class Room
{
    
    public int RoomNumber{get;set;}
    public string GuestName{get;set;}="";

    private decimal _PricePerNight;
    public decimal PricePerNight
    {
        get
        {
           
                return _PricePerNight;
          
        }
        set
        {
            if (value > 0)
            {
                 _PricePerNight=value;
            }
            
        }
        }
    public int Nights{get;set;}

    public decimal TotalPrice
    {
        get
        {
            return PricePerNight*Nights;
        }
    }

    public string BookingCode
    {
     get;private set;
    }="Ht1001";

}
public class Hotel
{
    public List<Room> rooms = new()
    {
        new Room
        {
            RoomNumber=101,
            GuestName="Sara",
            PricePerNight=100,
            Nights=5
        },
        new Room
        {
            RoomNumber=102,
            GuestName="Hana",
            PricePerNight=120,
            Nights=5
        },
        new Room
        {
            RoomNumber=103,
            GuestName="Ali",
            PricePerNight=100,
            Nights=3
        }
        
    };

    public Room this[int index]
    {
        get { return rooms[index];}
      
    }




}