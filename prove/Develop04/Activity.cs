using System.ComponentModel;

class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected string _prompt;
    protected List<string> _promptList;

    // --------

    // Breathing Constructor
    public Activity(string activityName)
    {
        _activityName = activityName;
        _duration = 0;

    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public string GetRandomPrompt(List<string> promptList)
    {
        // Get random index of list
        string prompt = "Random Prompt Placeholder";
        return prompt;
    }
    public void DisplaySpinner(int seconds)
    {
        // Code that displays the spinner
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\\");
            Thread.Sleep(250);

            Console.Write("\b|");
            Thread.Sleep(250);

            Console.Write("\b/");
            Thread.Sleep(250);

            Console.Write("\b-");
            Thread.Sleep(250);

            Console.Write("\b");
        }
        Console.Write(" ");
    }
    public void StartCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1200);

            Console.Write("\b");
            if (i >= 10)
            {
                Console.Write("\b");
            }
        }
        Console.WriteLine(" ");
    }
    public void Congratulate()
    {
        string letters = "";
        string word = "Congratulations!!";
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
        Console.WriteLine();
            




    }
    

}