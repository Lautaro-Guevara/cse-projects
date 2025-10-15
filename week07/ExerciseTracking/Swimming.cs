public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(DateTime date, int duration, int laps)
        : base("Swimming", date, duration)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 0.05; // assuming each lap is 50 meters, convert to kilometers
    }


    

}