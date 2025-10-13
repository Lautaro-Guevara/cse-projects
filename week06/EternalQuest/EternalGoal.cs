public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never completed, so no action is needed here.
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