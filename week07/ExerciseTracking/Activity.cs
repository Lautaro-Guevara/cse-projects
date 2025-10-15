public class Activity
{
    private string _type;
    private DateTime _date;
    private double _duration; // in minutes


    public Activity(string type, DateTime date, double duration)
    {
        _type = type;
        _date = date;
        _duration = duration;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        double distance = CalculateDistance();
        if (_duration > 0)
        {
            double speed = (distance / _duration) * 60; // convert to km/h
            return speed;
        }

        return 0;
    }

    public virtual double CalculatePace()
    {
        double distance = CalculateDistance();
        if (distance > 0)
        {
            double pace = _duration / distance; // in min/km
            return pace;
        }

        return 0;
    }


    public virtual string Summary()
    {
        return $"{_date.ToShortDateString()} {_type} ({_duration} min): Distance: {Math.Round(CalculateDistance(), 2)} km, Speed: {Math.Round(CalculateSpeed(), 2)} km/h, Pace: {Math.Round(CalculatePace(), 2)} min per km";
    }
    

}