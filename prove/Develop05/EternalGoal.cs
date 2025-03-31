class EternalGoal:Goal{
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, int completions)
    :base(name, description, points, status)
    {
        _numberOfCompletions = completions;
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
            EternalGoal eternalGoal = new EternalGoal(name,description,points,status,0);
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
        return $"{base.ToString()} Completions: {_numberOfCompletions}";
    }
    // public override string ListGoal()
    // {
    //     return base.ListGoal();
    // }
}