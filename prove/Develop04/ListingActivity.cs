using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class ListingActivity : Activity
{
    private List<string> _responseList;


    public ListingActivity(List<string> responseList) : base("Listing Activity")
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _responseList = responseList;
    }
    public List<string> GetResponseList()
    {
        return _responseList;
    }

    public void StartListingActivity()
    {
        string prompt = GetRandomPrompt(_promptList);
        Console.WriteLine($"--{prompt}--");
        Console.WriteLine("Type as many responses to the prompt as you can before time runs out.");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Write("You may begin in: ");
        StartCountdown(5);
        DateTime currentTime = DateTime.Now;
        do
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responseList.Add(response);
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
        
        Console.WriteLine($"You listed {_responseList.Count()} items!");
        Console.WriteLine();
        Congratulate();
        Console.WriteLine($"Well Done!! \n\nYou have completed {GetDuration()} seconds of the {_activityName}.");

    }



}
