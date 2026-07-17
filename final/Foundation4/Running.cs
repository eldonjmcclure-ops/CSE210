class Running : Activity 
{
    private double _distance;

    public Running (double distance, DateTime date, int lengthMinutes, string activityType) : base(date, lengthMinutes, activityType)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double GetSpeed()
    {
        return _distance / _lengthMinutes * 60;
    }
    public override double GetPace()
    {
        return _lengthMinutes / _distance;
    }
}