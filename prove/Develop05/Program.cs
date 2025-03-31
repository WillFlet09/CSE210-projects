using System;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        GoalList _goals = new GoalList();
        Console.WriteLine("Welcome to the Goals Program! \nYou'll be able to make a list of goals which you can come back to and update all within the program \nPlease select from the options below");
        while(menu != 6)
        {
            _goals.DisplayScore();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Which will you choose? ");
            menu = int.Parse(Console.ReadLine());

            if(menu == 1)
            {
                _goals.AddGoal();
            }
            if(menu == 2)
            {
                _goals.DisplayGoals();
            }
            if(menu == 3)
            {
                _goals.SaveGoals();
            }
            if(menu == 4)
            {
                _goals.LoadGoals();
            }
            if(menu == 5)
            {
                _goals.RecordEvent();
            } 
        }
    }
}