class EternalGoal:Goal{
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, int completions)
    :base(name, description, points, status)
    {
        _numberOfCompletions = completions;
    }
    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        _numberOfCompletions = _numberOfCompletions + 1;
        MarkComplete();
        return GetPoints();
    }
    public override string ToString()
    {
        return $"{base.ToString()}#{_numberOfCompletions}";
    }
    public override string ListGoal()
    {
        return $"{base.ListGoal()} Completions: {_numberOfCompletions}";
    }
}