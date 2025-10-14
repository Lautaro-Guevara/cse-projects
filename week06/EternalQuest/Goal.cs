public class Goal{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Congratulations! You have earned " + this._points + " points!");
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }

    public string GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortName;
    }
}