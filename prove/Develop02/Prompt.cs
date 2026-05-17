class Prompt()
{
    public List<string> _prompts = new List<string>()
    {"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "How did the Spirit prompt me to do good today?",
        "How did I make someone's day better today?",
        "What did I have for breakfast today?"
    };
    public string GetPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }


}
