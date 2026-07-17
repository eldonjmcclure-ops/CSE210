using System.Net.NetworkInformation;

class Swimming : Activity
{
    private int _laps;
	
	public Swimming(int laps, DateTime date, int lengthMinutes, string activityType) : base(date, lengthMinutes, activityType)
    {
        _laps = laps;
    }
	public int GetLaps()
    {
        return _laps;
    }
	public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _lengthMinutes * 60;
    }
    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }
}