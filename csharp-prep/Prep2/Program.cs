using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade? ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);
        string Grade = "U";

        if (x >= 93) 
        {
            Grade = "A";
        }

        if (x >= 90 && x < 93)
        {
            Grade = "A-";
        } 

        if (x >= 87 && x < 90)
        {
            Grade = "B+";
        } 

        if (x >= 83 && x < 87)
        {
            Grade = "B";
        }

        if (x >= 80 && x < 83)
        {
            Grade = "B-";
        }

        if (x >= 77 && x < 80)
        {
            Grade = "C+";
        }

        if (x >= 73 && x < 77)
        {
            Grade = "C";
        }

        if (x >= 70 && x <73)
        {
            Grade = "C-";
        }

        if (x >= 67 && x < 70)
        {
            Grade = "D+";
        }

        if (x >= 63 && x < 67)
        {
            Grade = "D";
        }

        if (x >= 60 && x < 63)
        {
            Grade = "D-";
        }

        if (x >= 63 && x < 60)
        {
            Grade = "F";
        }

        if (x < 63)
        {
            Grade = "F-";
        }

        Console.WriteLine($"You scored {x} so you get a(n) {Grade}");

        if(x >= 70)
        {
            Console.WriteLine("You Passed the Class!");
        }
        else
        {
            Console.WriteLine("You Failed!");
        }

    }
}