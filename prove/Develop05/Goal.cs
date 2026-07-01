using System.Data;

abstract class Goal
{
    protected string _name;

	protected string _description;
	
	protected int _points;

	protected bool _isCompleted;

	
	
 	public Goal(string name, string description, int points, bool isCompleted = false)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    } 

    public abstract int GetPointTotal();

	public void SetName(string name)
    {
        _name = name;
    }
	
	public string GetName()
    {
        return _name;
    }
    

	public void SetDescription(string description)
    {
        _description = description;
    }
	
	public string GetDescription()
    {
        return _description;
    }

	public void SetPoints(int points)
    {
        _points = points;
    }
	
	public int GetPoints()
    {
        return _points;
    }

	public void SetCompletion(bool completed)
    {
        _isCompleted = completed;
    }

	public bool GetCompletion()
    {
        return _isCompleted;
    }
	
	public abstract void Display(int index);

	public abstract string GetSaveString();

	public static void SaveGoalsToFile(List<Goal> recordedGoals)
    {
        Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Goal goal in recordedGoals)
                    {
                        string saveString = goal.GetSaveString();
                        outputFile.WriteLine(saveString);
                    }
                    
                }
                Console.WriteLine();
    }
	public static void ListGoals(List<Goal> recordedGoals)
    {
        Console.WriteLine("\nThe goals are:");
            if (recordedGoals.Count() != 0)
            {
                for (int i = 0; i < recordedGoals.Count(); i++)
                    {
                        Goal goal = recordedGoals[i];
                        goal.Display(i);
                    }
                    Console.WriteLine();
            }
        else
        {
            Console.WriteLine("No goals detected.");
        }
                
    }
	public abstract int RecordEvent();

	public static List<Goal> LoadGoalsFromFile()
    {
        List<Goal> recordedGoals = new List<Goal>();

        Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(":");

                        string goalName = parts[0];
                        string goalDetails = parts[1];
                        if (goalName == "SimpleGoal")
                        {
                            string[] pieces = goalDetails.Split("|");
                            string name = pieces[0];
                            string description = pieces[1];
                            int points = int.Parse(pieces[2]);
                            bool isCompleted = bool.Parse(pieces[3]);
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isCompleted);
                            recordedGoals.Add(simpleGoal);
                        }
                        else if (goalName == "ChecklistGoal")
                        {
                            string[] pieces = goalDetails.Split("|");
                            string name = pieces[0];
                            string description = pieces[1];
                            int points = int.Parse(pieces[2]);
                            int bonusPoints = int.Parse(pieces[3]);
                            int bonusRequirement = int.Parse(pieces[4]);
                            int timesCompleted = int.Parse(pieces[5]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonusPoints, bonusRequirement, timesCompleted);
                            recordedGoals.Add(checklistGoal);
                        }

                        else if (goalName == "EternalGoal")
                        {
                            string[] pieces = goalDetails.Split("|");
                            string name = pieces[0];
                            string description = pieces[1];
                            int points = int.Parse(pieces[2]);
                            int total = int.Parse(pieces[3]);
                            EternalGoal eternalGoal = new EternalGoal(name, description, points);
                            recordedGoals.Add(eternalGoal);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"File '{filename}' not found.");
                }
        return recordedGoals;
    }
}