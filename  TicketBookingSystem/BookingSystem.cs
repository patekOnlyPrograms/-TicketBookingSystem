namespace TicketBookingSystem;

public class BookingSystem
{
    private List<Event> Tickets;

    
    public void ListOfTicketsBought()
    {
        Console.WriteLine("Tickets Bought");
        for (int i = 1; i <= Tickets.Count; i++)
        {
            Console.WriteLine($"Ticket ID: {i}, ");
        }
    }
    
    public void BookTickets(int eventID, int numTickets)
    {
        Event ticket = Tickets.Find(t => t.EventID == e)
        
        if (ticket.TotalCapacity)
        {
            
        }
        
        Console.WriteLine("Booking tickets for: ");
        ticket.TotalCapacity -= 1;
        
    }
}