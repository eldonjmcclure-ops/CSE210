class Scripture
{
    //attributes
    private string _scriptureText;
    private List<Word> _words;
   
    //behaviors
    public Scripture(string scripture, List<Word> words) 
    {
        _scriptureText = scripture;
        _words = words;
    }
    public string GetScripture()
    {
        return _scriptureText;
    }
    public void AddWord(Word word)
    {
        _words.Add(word);
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public int GetRandomIndex()
    {
        int randomIndex = Random.Shared.Next(_words.Count);
        return randomIndex;
    }
}