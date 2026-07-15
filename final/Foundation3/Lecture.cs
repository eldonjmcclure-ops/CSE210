class Lecture : Event
{
    public string _speakerName;
	public int _capacity;
	
	public Lecture(string speakerName, int capacity, string eventType, string title, string description, DateTime dateTime, Address address) : base(eventType, title, description, dateTime, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
	public string GetSpeakerName() 
    {
        return _speakerName;
    }
	public void SetSpeakerName(string speakerName) 
    {
        _speakerName = speakerName;
    }
	public int GetCapacity() 
    {
        return _capacity;
    }
	public void SetCapacity(int capacity) 
    {
        _capacity = capacity;
    }

	public override void ShowFullDetails() 
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"- {_description}");
        Console.WriteLine($"{GetTimeFromDateTime(_dateTime)}, {GetDateFromDateTime(_dateTime)}");
        Console.WriteLine($"{_address.GetStreetAddress()}, {_address.GetCity()} {_address.GetStateOrProvince()}");
        Console.WriteLine($"Capacity: {_capacity} persons.");
    }
}