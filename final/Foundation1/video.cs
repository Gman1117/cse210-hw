public class Video
{
    
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

 
    public string Title 
    {
        get { return _title; }
        set { _title = value; }
    }


    public string Author 
    {
        get { return _author; }
        set { _author = value; }
    }


    public int LengthInSeconds 
    {
        get { return _lengthInSeconds; }
        set { _lengthInSeconds = value; }
    }


    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    public int GetCommentCount()
    {
        return _comments.Count;
    }

    
    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        
        Console.WriteLine("Comments:");
        foreach (var comment in GetComments())
        {
            Console.WriteLine(comment);
        }
        Console.WriteLine(); 
    }
}
