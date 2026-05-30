class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    //behaviors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference(string newBook, int newChapter, int startVerse, int endVerse)
    {
        
    }
    public void GetReference()
    {

    }

}