class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
	

	public override void Display(int index)
    {
        
        Console.WriteLine($"{index + 1}. [ ] {_name} ({_description})");    
    
    }

	public override string GetSaveString()
    {
        string saveString = $"EternalGoal:{_name}|{_description}|{_points}|{_timesCompleted}";
        return saveString;
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Congratulations!  You completed your goal!");
        Console.WriteLine($"You earned {_points} points!");
        _timesCompleted += 1;

        return _points;
    }

    public override int GetPointTotal()
    {
        throw new NotImplementedException();
    }

}