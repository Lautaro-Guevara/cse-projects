public class Video
{
    string _title;
    string _author;
    int _length; // In seconds
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int CountComments()
    {
        return _comments.Count();
    }

    private string FormatLength()
    {
        if (_length < 60)
        {
            return $"0:{_length}";
        } else if(_length < 3600) {

            int minutes = _length / 60;
            int seconds = _length % 60;
            return $"{minutes}:{seconds:D2}";
        } else
        {
            int hours = _length / 3600;
            int minutes = (_length % 3600) / 60;
            int seconds = _length % 60;

            return $"{hours}:{minutes:D2}:{seconds:D2}";
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_title} - {_author} ({FormatLength()})");
        Console.WriteLine($"Number of comments: {CountComments()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}