using System;

public abstract class Goal{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = base.ToString();

    }

    public string GetName()
    {
        return _name;
    }

    public string SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }

    public string SetDescription()
    {
        Console.Write("What is a short description? ");
        _description = Console.ReadLine();
        return _description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _numberOfPoints;
    }
    public int SetPoints()
    {
        Console.Write("What would be the amount of points associated with this goal? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
        return _numberOfPoints;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public bool MarkComplete()
    {
        this._status = true;
        return this._status;
    }
    public virtual string ListGoal()
    {
        string statusMarker = " ";
        if(_status == true)
        {
            statusMarker = "X";
        }
        return $"[{statusMarker}] {_name}: ({_description}), Points: {_numberOfPoints}";
    }
    public override string ToString()
    {
        return $"{_goalType}#{_name}#{_description}#{_numberOfPoints}#{_status}";
    }
    public virtual string GetGoalType()
    {
        return _goalType;
    }
    public abstract int RecordEvent();
    
    public abstract void RunGoal();
}