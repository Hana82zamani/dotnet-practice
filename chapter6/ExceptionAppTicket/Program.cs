using TicketLibException;

CinemaTicket cinemaTicket =new();

try
{
   cinemaTicket.Reserve(15);
}
catch(TicketException ex)
{
    Console.WriteLine(ex.Message);
}