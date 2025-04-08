class Swimming:Activity{
    private double _swimmingLaps;
    private int _speed;
    public Swimming(DateTime date, int minutes, double swimmingLaps, int speed)
    :base(date,minutes)
    {
        _swimmingLaps = swimmingLaps;
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _swimmingLaps * 50 / 1000 * 0.62;
        return distance;
    }
    public override int GetPace()
    {
        int pace = 60/_speed;
        return pace;
    }
    public override string GetSummary()
    {
        double distance = GetDistance();
        int pace = GetPace();
        DateTime date = GetDate();
        string activityType = GetActivityType();
        int minutes = GetMinutes();
        return $"{date} {activityType}({minutes} min)-Distance: {distance} miles, Speed: {_speed} mph, Pace: {pace} min per mile";
    }
}