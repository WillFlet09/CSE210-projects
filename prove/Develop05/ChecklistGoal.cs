class ChecklistGoal:Goal{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, int completions, int max, int bonus)
    :base(name,description,points,status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public int GetCompletions()
    {
        return _numberOfCompletions;
    }
    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        Console.Write("What is the max amount of completions? ");
        _maxGoals = int.Parse(Console.ReadLine());
        Console.Write("What is the amount of bonus points for fufilling the goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
            
    }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        _numberOfCompletions = _numberOfCompletions + 1;
        if(_numberOfCompletions == _maxGoals)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }
        else{
            return GetPoints();
        }

    }
    public override string ToString()
    {
        return $"{base.ToString()}#{_numberOfCompletions}#{_maxGoals}#{_bonusPoints}";
    }
    public override string ListGoal()
    {
        return $"{base.ListGoal()} Completions: {_numberOfCompletions}/{_maxGoals}";
    }
}