public class Cycling : Activity
{
    private int _speed; // in km/h

    public Cycling(DateTime date, double duration, int speed)
        : base("Cycling", date, duration)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return (_speed * GetDuration()) / 60; // distance = speed * time (in hours)
    }
}