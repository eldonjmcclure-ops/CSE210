class Event
{
    protected string _eventType;
    protected string _title;
	protected string _description;
	protected DateTime _dateTime;
	protected Address _address;

	public Event(string eventType, string title, string description, DateTime dateTime, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
    public string GetType()
    {
        return _eventType;
    }
	public void SetType(string eventType) 
    {
        _eventType = eventType;
    }
	public string GetTitle() 
    {
        return _title;
    }
	public void SetTitle(string title) 
    {
        _title = title;
    }
	public string GetDescription() 
    {
        return _description;
    }
	public void SetDescription(string description) 
    {
        _description = description;
    }
	public DateTime GetDateTime() 
    {
        return _dateTime;
    }
	public void SetDateTime(DateTime dateTime) 
    {
        _dateTime = dateTime;
    }	
    public Address GetAddress() 
    {
        return _address;
    }
	public void SetAddress(Address address) 
    {
        _address = address;
    }

    public string GetDateFromDateTime(DateTime dateTime)
    {
        DateTime dateOnly = dateTime.Date;
        return dateOnly.ToString("d");
    }
    public string GetTimeFromDateTime(DateTime dateTime)
    {
        return dateTime.ToString("h:mm tt");
    }

	public void ShowStandardDetails() 
    {
        Console.WriteLine($"{_eventType}: {_title}");
        Console.WriteLine($"- {_description}");
        Console.WriteLine($"When: {GetDateFromDateTime(_dateTime)} at {GetTimeFromDateTime(_dateTime)}");
    }
	public virtual void ShowFullDetails() 
    {
        
    }
	public void ShowShortDescription() 
    {
        Console.WriteLine($"{_eventType} - {_title}");
        Console.WriteLine($"{GetDateFromDateTime(_dateTime)}");
    }

}