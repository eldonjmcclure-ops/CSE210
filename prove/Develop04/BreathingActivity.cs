using System.Security.Cryptography.X509Certificates;

class BreathingActivity : Activity
{
    private int _inhaleTime;
    private int _exhaleTime;
    private int _holdBreath;

    public BreathingActivity(int inhale, int holdBreath, int exhale) : base("Breathing Activity")
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        _inhaleTime = inhale;
        _exhaleTime = exhale;
        _holdBreath = holdBreath;
    }
    public int GetInhaleTime()
    {
        return _inhaleTime;
    }
    public void SetInhaleTime(int inhale)
    {
        _inhaleTime = inhale;
    }
    public int GetExhaleTime()
    {
        return _exhaleTime;
    }
    public void SetExhaleTime(int exhale)
    {
        _exhaleTime = exhale;
    }
    public int GetHoldBreath()
    {
        return _holdBreath;
    }
    public void SetHoldBreath(int seconds)
    {
        _holdBreath = seconds;
    }

    public void StartBreathingActivity()
    {
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            int time = StartBreathCycle();
            elapsedTime += time;
        }
        Congratulate();
        Console.WriteLine($"Well Done!! \n\nYou have completed {GetDuration()} seconds of the {_activityName}.");
    }
    public int StartBreathCycle()
    {
        Console.Write("Breathe in... ");
        StartCountdown(_inhaleTime);
        Console.WriteLine();

        if (_holdBreath > 0)
        {
            Console.Write("Hold... ");
            StartCountdown(_holdBreath);
            Console.WriteLine();
        }

        Console.Write("Now breathe out... ");
        StartCountdown(_exhaleTime);

        Console.WriteLine();
        int elapsedTime = _inhaleTime + _holdBreath + _exhaleTime;
        return elapsedTime;
    }

}