class Reception : Event
{
    private string _rsvpEmail;

	public Reception(string eventType, string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(eventType, title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }
	public string GetRSVPEmail() 
    {
        return _rsvpEmail;
    }
	public void SetRSVPEmail(string rsvpEmail) 
    {
        _rsvpEmail = rsvpEmail;
    }
	public override void ShowFullDetails() 
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"- {_description}");
        Console.WriteLine($"{GetTimeFromDateTime(_dateTime)}, {GetDateFromDateTime(_dateTime)}");
        Console.WriteLine($"{_address.GetStreetAddress()}, {_address.GetCity()} {_address.GetStateOrProvince()}");
        Console.WriteLine($"RSVP via email at {_rsvpEmail}");
    }

}