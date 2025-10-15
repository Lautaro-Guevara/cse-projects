public class Running : Activity
{
    private int _distance; // in kilometers

    public Running(DateTime date, double duration, int distance)
        : base("Running", date, duration)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    

}