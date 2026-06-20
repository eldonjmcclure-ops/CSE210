using System.ComponentModel;

class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected string[] _promptList;

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

    public void SetPromptList(string[] prompts)
    {
        _promptList = prompts;
    }

    public string GetRandomPrompt(string[] promptList)
    {
        // Get random index of list
        int randomIndex = Random.Shared.Next(promptList.Length);
        string randomPrompt = promptList[randomIndex];
        return randomPrompt;
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
        string word = "Great Job!";
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