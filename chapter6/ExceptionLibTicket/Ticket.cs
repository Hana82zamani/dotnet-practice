namespace TicketLibException;

public class TicketException : Exception
{
    public TicketException (string message): base(message)
    {
    }

}
public class CinemaTicket
{
    public void Reserve(int seatNumber)
    {
        if (seatNumber <1 || seatNumber > 50)
        {
            throw new TicketException("invalid seat number");
        }
        else
        {
            Console.WriteLine("Seat reserved successfully.");
        }
    }
}