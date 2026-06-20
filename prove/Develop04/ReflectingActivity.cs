
class ReflectingActivity : Activity
{
    private string[] _questions;
    private string _question;
    private int _pauseTime;

    public ReflectingActivity(string[] questions, int pauseTime) : base("Reflecting Activity")
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _questions = questions;
        _pauseTime = pauseTime;
    }
    public string GetQuestion()
    {
        return _question;
    }
    public void SetQuestion(string question)
    {
        _question = question;
    }
    public string[] GetList()
    {
        return _questions;
    }
    public int DisplayQuestion(int index)
    {
            Console.WriteLine(_questions[index]);
            DisplaySpinner(_pauseTime);
            return _pauseTime;
    }
    public void StartReflectingActivity()
    {
        
        Console.WriteLine($"--{GetRandomPrompt(_promptList)}--");
        Console.Write("Now I'm going to ask you a few questions about your experience.  Please ponder them as we go...");
        Console.Write("You may begin in: ");
        StartCountdown(5);
        int index = 0;
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine();
            int time = DisplayQuestion(index);
            int newIndex = index += 1;
            index = newIndex;
            elapsedTime += time;
        }
        Congratulate();
        Console.WriteLine($"Well Done!! \n\nYou have completed {GetDuration()} seconds of the {_activityName}.");
    }
}