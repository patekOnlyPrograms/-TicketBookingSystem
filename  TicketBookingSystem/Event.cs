namespace TicketBookingSystem;

public abstract class Event
{
    public string EventID;
    public string EventName;
    public DateTime Time;
    public String Location;
    public int TotalCapacity;

    protected Event(string eventID, string eventName, DateTime time, string location, int totalCapacity)
    {
        EventID = eventID;
        EventName = eventName;
        Time = time;
        Location = location;
        TotalCapacity = totalCapacity;
    }

    public virtual string ShowEventDetails()
    {
        return $"The event is {EventName}, at {Time:d} and in {Location}";
    }

    
}