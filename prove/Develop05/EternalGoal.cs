class EternalGoal:Goal{
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, string goalType, int completions)
    :base(name, description, points, status, goalType)
    {
        _numberOfCompletions = completions;
    }
    // public override void RunGoal()
    // {
    //     throw new NotImplementedException();
    // }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
    // public override string ToString()
    // {
    //     return base.ToString();
    // }
    // public override string ListGoal()
    // {
    //     return base.ListGoal();
    // }
}