class Word
{
    //attributes
    private bool _isHidden;
    private string _word;
    private string _hidden;

    public Word()
    {
        _isHidden = false;
    }
    //behaviors
    public void Hide()
    {
        _isHidden = true;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public void SetHiddenWord()
    {
        char[] secretWord = new char[_word.Length];
        for (int i = 0; i < secretWord.Length; i++)
        {
            secretWord[i] = '_';
        } 
        _hidden = string.Join("", secretWord);
    }
    public string GetWord()
    {
        if (_isHidden == true)
        {
            return _hidden;
        }
        else
        {
            return _word;    
        }
        
    }
    public bool GetHiddenStatus()
    {
        return _isHidden;
    }
}