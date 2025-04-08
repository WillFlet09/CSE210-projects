class Activity{
    public List<Activity> _Activites;
    private int _minutes;
    private DateTime _date;
    private double _distance;
    private int _speed;
    private int _pace;
    private string _activityType;

    public Activity(DateTime date, int minutes){
        _activityType = base.ToString();
        _date = date;
        _minutes = minutes;
        _Activites = new List<Activity>();
    }
    public void ListIterate()
    {
        foreach(Activity activity in _Activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_activityType} ({_minutes} min)-Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
    }
    public virtual double GetDistance()
    {
        double distance = _distance;
        return distance;
    }
    public virtual int GetSpeed()
    {
        return _speed;
    }
    public virtual int GetPace()
    {
        return _pace;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public string GetActivityType()
    {
        return _activityType;
    }
}