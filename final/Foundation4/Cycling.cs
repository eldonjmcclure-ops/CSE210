class Cycling
{
    private int _mph;

	public Cycling(int mph)
    {
        _mph = mph;
    }
	public int GetSpeed()
    {
        return _mph;
    }
	public void SetSpeed(int mph)
    {
        _mph = mph;
    }
	public override string GetSummary()
    {
        
    }
}
