class ChecklistGoal:Goal{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int completions, int max, int bonus)
    :base(name,description,points,status, goalType)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public int GetCompletions()
    {
        return _numberOfCompletions;
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