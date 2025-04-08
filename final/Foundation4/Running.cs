class Running:Activity{
    private int _distance;
    public Running(DateTime date,int minutes, int distance)
    :base(date, minutes)
    {
        _distance = distance;
    }
    public override int GetPace()
    {
        int minutes = GetMinutes();
        int pace = minutes/_distance;
        return pace;
    }
    public override int GetSpeed()
    {
        int pace = GetPace();
        int speed = 60/pace;
        return speed;
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