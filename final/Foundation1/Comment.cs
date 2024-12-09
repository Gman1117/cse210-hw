public class Comment
{
    private string _commenterName;
    private string _commentText;

    public string CommenterName 
    {
        get { return _commenterName; }
        set { _commenterName = value; }
    }
    public string CommentText 
    {
        get { return _commentText; }
        set { _commentText = value; }
    }


    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }


    public override string ToString()
    {
        return $"[{_commenterName}]: {_commentText}";
    }
}