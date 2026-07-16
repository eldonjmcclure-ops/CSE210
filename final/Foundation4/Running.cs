class Running : Activity 
{
    private double _distance;

    public Running (double distance, DateTime date, int lengthMinutes) : base(date, lengthMinutes)
    {
        
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
         
    }
}
	