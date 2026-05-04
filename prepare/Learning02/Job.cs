public class Job
{
    public string _jobTitle;
    public string _company;
    public string _responsibilities;
    public int _startYear;
    public int _endYear;

    // Methods
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}