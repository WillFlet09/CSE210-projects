class Cycling:Activity{
    private int _distance;
    private int _minutes;
    public Cycling(DateTime date, int distance, int minutes)
    :base(date,minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }
    public override int GetSpeed()
    {
        int speed = (_distance * _minutes) / 60;
        return speed;
    }
    public override int GetPace()
    {
        int speed = GetSpeed();
        int pace = 60/speed;
        return pace;
    }
    public override string GetSummary()
    {
        int speed = GetSpeed();
        int pace = GetPace();
        DateTime date = GetDate();
        string activityType = GetActivityType();
        int minutes = GetMinutes();
        return $"{date} {activityType}({minutes} min)-Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}