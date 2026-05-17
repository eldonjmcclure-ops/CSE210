class Entry
{
    // attributes
    public string _date;
    public string _prompt;
    public string _response;
    public int _mood = -1;

    // behaviors
    public void Display()
    {
        string moodScore;
        if (_mood == -1)
        {
            moodScore = "__";
        }
        else
        {
            moodScore = Convert.ToString(_mood);
        }

        Console.WriteLine($"{_date} -- Mood: {moodScore}/10 -- {_prompt} -- {_response}");
        Console.WriteLine("");
    }
}
