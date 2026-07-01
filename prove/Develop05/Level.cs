class Level
{
    private int _currentLevel;

    private int _minLevel;
    private int _maxLevel;
    private List<int> _thresholds;


    public Level(int minLevel, int maxLevel, List<int> thresholds)
    {
        _currentLevel = 1;
        _minLevel = minLevel;
        _maxLevel = maxLevel;
        _thresholds = thresholds;

    }

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public void SetCurrentLevel(int level)
    {
        _currentLevel = level;
    }

    public int GetMinLevel()
    {
        return _minLevel;
    }

    public void SetMinLevel(int level)
    {
        _currentLevel = level;
    }

    public int GetMaxLevel()
    {
        return _maxLevel;
    }

    public void SetMaxLevel(int level)
    {
        _currentLevel = level;
    }

    public List<int> GetThresholds()
    {
        return _thresholds;
    }

    public void SetThresholds(List<int> thresholds)
    {
        _thresholds = thresholds;
    }

    public int CheckLevel(int points)
    {
        int level = 1;
        foreach (int threshold in _thresholds)
        {
            if (points >= threshold)
            {
                level++;
            }
            else
            {
                // Escape the loop once the current level is reached.
                // Avoids dozens of excess calculations.
                // Good to know as well how break works
                break;
            }
            
        }
        return level;
        
    }
    public void LevelUpAnimation()
    {
        string letters = "";
        string word = "Level Up!";
            Console.Write("--");
            Thread.Sleep(100);
            foreach (char letter in word)
        {
            letters += letter;
            Console.Clear();
            Console.Write($"-{letters}-");
            Thread.Sleep(100);
        }

        Console.WriteLine();
        Console.WriteLine($"You are now Level {_currentLevel}!  Keep working hard!");
    }

}