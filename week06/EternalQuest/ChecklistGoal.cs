public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        
        if (IsComplete())
        {

            Console.WriteLine($"Congratulations! You have completed the checklist goal and earned a bonus of {_bonus} points!");
            Console.WriteLine("You have earned" + (int.Parse(this.GetPoints()) + _bonus) + " points in total!");
        }
        else
        {
            base.RecordEvent();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{base.GetStringRepresentation()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}