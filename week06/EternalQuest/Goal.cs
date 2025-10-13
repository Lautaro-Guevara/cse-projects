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

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetDetails()
    {
        return $"Short Name: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}