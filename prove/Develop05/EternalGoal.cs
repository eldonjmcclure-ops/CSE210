class EternalGoal : Goal
{
    private int _total;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _total = 0;
    }

    public EternalGoal(string name, string description, int points, int total) : base(name, description, points)
    {
        _total = total;
    }
	

	public override void Display(int index)
    {
        
        Console.WriteLine($"{index + 1}. [ ] {_name} ({_description})");    
    
    }

	public override string GetSaveString()
    {
        string saveString = $"EternalGoal:{_name}|{_description}|{_points}|{_total}";
        return saveString;
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Congratulations!  You completed your goal!");
        Console.WriteLine($"You earned {_points} points!");
        _total += _points;

        return _points;
    }

    public override int GetPointTotal()
    {
        return _total;
    }

}