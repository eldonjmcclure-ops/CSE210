class Activity
{
    protected string _activityType;
	protected DateTime _date;
	protected int _lengthMinutes;
	
	
	public Activity(DateTime date, int lengthMinutes, string activityType)
    {
        _activityType = activityType;
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
	public DateTime GetDate()
    {
        return _date;
    }
	public void SetDate(DateTime date)
    {
        _date = date;
    }
	public int GetLength()
    {
        return _lengthMinutes;
    }
	public void SetLength(int lengthMinutes)
    {
        _lengthMinutes = lengthMinutes;
    }
    public string GetDateOnly()
    {
        return _date.ToString("dd MMM yyyy");
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
	public void DisplaySummary()
    {
        double distance = Math.Round(GetDistance(),1);
        double speed = Math.Round(GetSpeed(),1);
        double pace = Math.Round(GetPace(),1);

        Console.WriteLine($"{GetDateOnly()} {_activityType} ({_lengthMinutes} min)- Distance: {distance} miles, Speed {speed} mph, Pace: {pace} min per mile");
    }

}