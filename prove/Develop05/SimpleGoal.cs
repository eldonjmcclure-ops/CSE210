class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    
	
	public override void Display(int index)
    {
        if (_isCompleted)
        {
            Console.WriteLine($"{index + 1}. [X] {_name} ({_description})");    
        }
        else
        {
            Console.WriteLine($"{index + 1}. [ ] {_name} ({_description})"); 
        }
        
    }

	public override string GetSaveString()
    {
        string saveString = $"SimpleGoal:{_name}|{_description}|{_points}|{_isCompleted}";
        return saveString;
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine("Congratulations!  You completed your goal!");
        Console.WriteLine($"You earned {_points} points!");

        return _points;
    }

    public override int GetPointTotal()
    {
        if (_isCompleted)
        {
            
            return _points;
        }
        else
        {
            return 0;
        }
    }
}