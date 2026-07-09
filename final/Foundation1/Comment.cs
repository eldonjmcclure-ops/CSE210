class Comment
{
    private string _author;
	private string _commentText;
	
	public Comment(string author, string commentText)
    {
        _author = author;
        _commentText = commentText;
    }
	public string GetAuthor()
    {
        return _author;
    }
	public void SetAuthor(string author)
    {
        _author = author;
    }
	public string GetCommentText()
    {
        return _commentText;
    }
	public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }

}