public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{base.GetStringRepresentation()}";
    }
}