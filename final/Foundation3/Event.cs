
public class Event
{
    private string _eventTiltle;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    private Address _address = new();

    
    public Event()
    {
        
    }

    public void SetEventType(string theEvent)
    {
        _eventType = theEvent;
    }

    private string GetEventType()
    {
        return _eventType;
    }

    private void SetEventTitle()
    {
        Console.Write("What is this event called?: ");
        _eventTiltle = Console.ReadLine();
    }

    public string GetEventTitle()
    {
        return _eventTiltle;
    }

    private void SetEventDescription()
    {
        Console.Write("Please give an event description: ");
        _description = Console.ReadLine();
    }

    public string GetEventDescription()
    {
        return _description;
    }

    private void SetEventDate()
    {
        Console.Write("What is the date of the event? (MM-DD-YY): ");
        _date = Console.ReadLine();
    }

    public string GetDate()
    {
        return _date;
    }

    private void SetEventTime()
    {
        Console.Write("When is the event time?: ");
        _time = Console.ReadLine();
    }

    public string GetEventTime()
    {
        return _time;
    }

    public void BookEvent()
    {
        SetEventTitle();
        SetEventDescription();
        SetEventDate();
        SetEventTime();
        _address.SetAddress();
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event name: {GetEventTitle()}\nEvent Description: {GetEventDescription()}\nEvent Date: {GetDate()}Time: {GetEventTime()}\n{_address.DisplayAddressInfo()}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"Event type: {GetEventType()}\nEvent title: {GetEventTitle()}\nEvent date: {GetDate()}");
    }


}