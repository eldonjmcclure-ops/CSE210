class Cycling : Activity
{
    private double _mph;

	public Cycling(int mph, DateTime date, int lengthMinutes, string activityType) : base(date, lengthMinutes, activityType)
    {
        _mph = mph;
    }
	public override double GetSpeed()
    {
        return _mph;
    }
	public void SetSpeed(int mph)
    {
        _mph = mph;
    }
    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
    public override double GetDistance()
    {
        return _lengthMinutes / 60.0 * GetSpeed();
    }
	
}
