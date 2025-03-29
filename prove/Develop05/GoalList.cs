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
        Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description? ");
            string description = Console.ReadLine();
            Console.Write("What would be the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            bool status = false;
        if(choice == 1)
        {
            string goalType = "Simple";
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, status, goalType);
            _goals.Add(simpleGoal);
        }
        if(choice == 2)
        {
            string goalType = "Eternal";
            EternalGoal eternalGoal = new EternalGoal(name,description,points,status,goalType,0);
            _goals.Add(eternalGoal);
        }
        if(choice == 3)
        {
            Console.Write("What is the max amount of completions? ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("What is the amount of bonus points for fufilling the goal? ");
            int bonus = int.Parse(Console.ReadLine());
            string goalType = "CheckList";
            ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,status,goalType,0,max,bonus);
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
            if(goalType == "Simple")
            {
                SimpleGoal simple = new SimpleGoal(name,description,points,status,goalType);
                _goals.Add(simple);
            }
            if(goalType == "Eternal")
            {
                int completions = int.Parse(parts[6]);
                EternalGoal eternal = new EternalGoal(name,description,points,status,goalType,completions);
                _goals.Add(eternal);
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
                string name = goal.GetName();
                string description = goal.GetDescription();
                int points = goal.GetPoints();
                bool status = goal.GetStatus();
                string goalType = goal.GetGoalType();
                if(goalType == "Simple")
                {
                outputFile.WriteLine($"{name}#{description}#{points}#{status}#{goalType}");
                }
                if(goalType == "Eternal")
                {
                  outputFile.WriteLine($"{name}#{description}#{points}#{status}#{goalType}");  
                }
            }
        }           
    }
    public void DisplayGoals()
    {
        
        Console.WriteLine("Your goals are:");
        foreach(Goal goal in _goals)
        {
            bool filter = goal.GetStatus();
            if(filter == true)
            {
                Console.WriteLine($"[X] {goal.GetName()} ({goal.GetDescription()}) Points: {goal.GetPoints()}");
            }
            else
            {
                Console.WriteLine($"[] {goal.GetName()} ({goal.GetDescription()}) Points: {goal.GetPoints()}");
            }
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
        string filter = _goals[acomp].GetGoalType();
        if(filter == "Simple")
        {
            bool complete = _goals[acomp].GetStatus();
            if(complete == false){
                _goals[acomp].MarkComplete();
                int addedPoints = _goals[acomp].GetPoints();
                _totalScore = _totalScore + addedPoints;
                Console.WriteLine($"Congratulations! You have recieved {addedPoints} points");
            }
            else
            {
                Console.WriteLine("The goal has already been acomplished");
            }
        }
        if(filter == "Eternal")
        {
            _goals[acomp].MarkComplete();
            int addedPoints = _goals[acomp].GetPoints();
            _totalScore = _totalScore + addedPoints;
            Console.WriteLine($"Congratulations! You have recieved {addedPoints} points");
        }
        if(filter == "Checklist")
        {
            int addedPoints = _goals[acomp].GetPoints();
            _totalScore = _totalScore + addedPoints;
             
            

        }
    }
}