using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    public static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    public static int SquareNumber(int Number)
    {
        int square = Number * Number;
        return square;
    }

    static void DisplayResults(string Name, int square)
    {
        Console.WriteLine($"{Name}, the square of your number is {square}");
    }
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int square = SquareNumber(Number);
        DisplayResults(Name, square);

    }
}