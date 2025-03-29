using System;

public abstract class Goal{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public Goal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;

    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _numberOfPoints;
    }
    // public int SetPoints()
    // {

    // }
    public bool GetStatus()
    {
        return _status;
    }
    public bool MarkComplete()
    {
        this._status = true;
        return this._status;
    }
    // public virtual string ListGoal()
    // {

    // }
    // public override string ToString()
    // {
    //     return base.ToString();
    // }
    public virtual string GetGoalType()
    {
        return _goalType;
    }
    public abstract int RecordEvent();
    
    // public abstract void RunGoal()
    // {

    // }
}