using System.Net;

class SimpleGoal:Goal{
    public SimpleGoal(string name, string description, int points, bool status, string goalType)
    :base(name,description,points,status, goalType)
    {

    }

    // public override void RunGoal()
    // {
        
    // }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }

}