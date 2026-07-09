class Video
{
    private string _title;
	private string _creator;
    private int _commentCount;
	private string _length;
	private List<Comment> _comments;

	public Video(string title, string creator, string length, List<Comment> comments)
    {
        _title = title;
        _creator = creator;
        _length = length;
        _comments = comments;
        _commentCount = _comments.Count();
    }
	public string GetTitle()
    {
        return _title;
    }
	public void SetTitle(string title)
    {
        _title = title;
    }
	public string GetCreator()
    {
        return _creator;
    }
	public void SetCreator(string creator)
    {
        _creator = creator;
    }
	public string GetLength()
    {
        return _length;
    }
	public void SetLength(string length)
    {
        _length = length;
    }
	public int GetCommentCount()
    {
        return _commentCount;
    }
	public void SetCommentCount(int commentCount)
    {
        _commentCount = commentCount;
    }
	public List<Comment> GetComments()
    {
        return _comments;
    }
	public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }
	public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            string author = comment.GetAuthor();
            string commentText = comment.GetCommentText();

            Console.WriteLine($"{author} said:");
            Console.WriteLine(commentText);
            Console.WriteLine();
        }
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_creator}");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Comments: {_commentCount}");
        Console.WriteLine();
        DisplayComments();
    }

}