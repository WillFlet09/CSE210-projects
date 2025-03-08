using System;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal1 = new Journal();
        int option = 0;
        while(option != 5){
            Console.Clear(); 
            Console.WriteLine("Welcome to the journal! 5 options will be presented to you so you can get on with your journal experience.");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do (by number)? ");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Journal1._WriteFromFile();
            }

            if(option == 2)
            {
                Journal1._DisplayJournal();
            }

            if(option == 3)
            {
                Journal1._WriteToFile();
            }

            if(option == 4)
            {
                Journal1._ReadFromFile();
            }

            if(option == 5)
            {
                Console.WriteLine("Thank you for using the journal!");
            }
        }
    }
}