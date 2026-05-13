class Entry
{
    //attributes
    public string _date;
    public string _response;
    //public string Response {get; sd;} is bad, don't use this.
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"{_date} -- {_prompt} -- {_response}");
    }
}