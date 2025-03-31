class ChecklistGoal:Goal{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int completions, int max, int bonus)
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
        Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
        Console.Write("What is a short description? ");
            string description = Console.ReadLine();
            Console.Write("What would be the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            bool status = false;
            Console.Write("What is the max amount of completions? ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("What is the amount of bonus points for fufilling the goal? ");
            int bonus = int.Parse(Console.ReadLine());
            string goalType = "CheckList";
            ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,status,goalType,0,max,bonus);
    }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return $"{base.ToString()}#{_numberOfCompletions}#{_maxGoals}#{_bonusPoints}";
    }
    // public override string ListGoal()
    // {
    //     return base.ListGoal();
    // }
}