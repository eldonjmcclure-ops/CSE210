class OutdoorGathering : Event
{
    private string _forecast;

	public OutdoorGathering(string eventType, string title, string description, DateTime dateTime, Address address, string forecast) : base(eventType, title, description, dateTime, address)
    {
        _forecast = forecast;
    }
	public string GetForecast() 
    {
        return _forecast;
    }
	public void SetForecast(string forecast) 
    {
        _forecast = forecast;
    }
	public override void ShowFullDetails() 
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"- {_description}");
        Console.WriteLine($"{GetTimeFromDateTime(_dateTime)}, {GetDateFromDateTime(_dateTime)}");
        Console.WriteLine($"{_address.GetStreetAddress()}, {_address.GetCity()} {_address.GetStateOrProvince()}");
        Console.WriteLine($"Weather: {_forecast}");
    }

}