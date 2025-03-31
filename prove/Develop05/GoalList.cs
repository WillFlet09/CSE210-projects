using System;
using System.Numerics;
using System.Runtime.CompilerServices;
class GoalList{
    List<Goal> _goals = new List<Goal>();

    private string _filename;

    private int _totalScore;

    public void Goals()
    {
    }
    public void AddGoal(){
        Console.WriteLine("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.Write("Which Goal Would you like it to be? ");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            SimpleGoal simple = new SimpleGoal("", "", 0, false);
            simple.RunGoal();
            _goals.Add(simple);
        }
        if(choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal("", "", 0, false, 0);
            eternalGoal.RunGoal();
            _goals.Add(eternalGoal);
        }
        if(choice == 3)
        {
            ChecklistGoal checklistGoal = new ChecklistGoal("", "", 0, false, 0, 0, 0);
            checklistGoal.RunGoal();
            _goals.Add(checklistGoal);
        }
    }

    public void LoadGoals(){
      Console.Write("What is the filename? ");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);
 
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
 
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool status = bool.Parse(parts[3]);
            string goalType = parts[4];
            if(goalType == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(name,description,points,status);
                _goals.Add(simple);
            }
            if(goalType == "EternalGoal")
            {
                int completions = int.Parse(parts[6]);
                EternalGoal eternal = new EternalGoal(name,description,points,status,completions);
                _goals.Add(eternal);
            }
            if(goalType == "ChecklistGoal")
            {
                int completions = int.Parse(parts[6]);
                int max = int.Parse(parts[7]);
                int bonus = int.Parse(parts[8]);
                ChecklistGoal checklist = new ChecklistGoal(name,description,points,status,completions,max,bonus);
                _goals.Add(checklist);
            }
   
        }
    }
    public void SaveGoals(){
        Console.Write("What is the file you are saving it to? ");
        _filename = Console.ReadLine();
        string filepath = $"./{_filename}";

        using (StreamWriter outputFile = new StreamWriter(filepath, true))
        {
            foreach(Goal goal in _goals)
            {
                goal.ToString();
            }
        }           
    }
    public void DisplayGoals()
    {
        
        Console.WriteLine("Your goals are:");
        foreach(Goal goal in _goals)
        {
                Console.WriteLine(goal.ListGoal());
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {_totalScore}");
    }
    public void RecordEvent(){
        int counter = 0;
        foreach(Goal goal in _goals)
        {
            counter = counter + 1;
            Console.WriteLine($"{counter}. {goal.GetName()}");
        }
        Console.Write("Which Goal did you accomplish? ");
        int acomp = int.Parse(Console.ReadLine());
        acomp = acomp - 1;
        int addedPoints = _goals[acomp].RecordEvent();
        _totalScore = _totalScore + addedPoints;
        Console.WriteLine($"Congratulations! You have recieved {addedPoints} points");
    }
}