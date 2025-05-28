using System.Security.Cryptography;

public class Video
{
    private string title;
    private string author;
    private int length;

    public List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int commentnumber()
    {
        return comments.Count;
    }
    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    public int Length
    {
        get { return length; }
    }

}