class Activity
{
    
	protected DateTime _date;
	protected int _lengthMinutes;
	
	
	public Activity(DateTime date, int lengthMinutes)
    {
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
	public virtual string GetSummary()
    {
        string summary = "";
        return summary;
    }

}