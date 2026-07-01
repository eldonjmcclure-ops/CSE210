class ChecklistGoal : Goal
{
    private int _bonusRequirement;
    private int _bonusPoints;
    private int _timesCompleted;

    private int _total;
	

	public ChecklistGoal(string name, string description, int points, int bonusRequirement, int bonusPoints) : base(name, description, points)
    {
        _bonusRequirement = bonusRequirement;
        _bonusPoints = bonusPoints;
        _total = 0;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int bonusRequirement, int timesCompleted, bool isCompleted, int total) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _bonusRequirement = bonusRequirement;
        _bonusPoints = bonusPoints;
        _isCompleted = isCompleted;
        _total = total;
    }

	
	public void SetBonusRequirement(int bonusRequirement)
    {
        _bonusRequirement = bonusRequirement;
    }
	
	public int GetBonusRequirement()
    {
        return _bonusRequirement;
    }

    public void SetBonus(int bonus)
    {
        _bonusPoints = bonus;
    }
	
	public int GetBonus()
    {
        return _bonusPoints;
    }
	
	public override void Display(int index)
    {
        
        if (_timesCompleted == _bonusRequirement)
        {
            Console.WriteLine($"{index + 1}. [X] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_bonusRequirement}");    
        }
        else
        {
            Console.WriteLine($"{index + 1}. [ ] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_bonusRequirement}"); 
        }

    }

	public override string GetSaveString()
    {
        string saveString = $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonusPoints}|{_bonusRequirement}|{_timesCompleted}|{_isCompleted}|{_total}";
        return saveString;
    }
    public override int RecordEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _bonusRequirement)
        {
            _isCompleted = true;
            Console.WriteLine("Congratulations!  You completed your goal!");
            int bonusTotal = _points + _bonusPoints;
            _total += bonusTotal;
            Console.WriteLine($"You earned {bonusTotal} points");
            return bonusTotal;
            
        }
        else
        {
            Console.WriteLine($"Way to go! {_timesCompleted}/{_bonusRequirement} completed!");
            Console.WriteLine($"You earned {_points} points!");
            _total += _points;
            return _points;
            
        }
        
    }

    public override int GetPointTotal()
    {
        return _total;
    }
}