using System.ComponentModel;
using System.Net;

class SimpleGoal:Goal{
    public SimpleGoal(string name, string description, int points, bool status)
    :base(name,description,points,status)
    {

    }


    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        string goalType = base.ToString();
    }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        return MarkComplete();
        
    }

}