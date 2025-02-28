using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);
        int x = 0;
        while (x != number)
        {
        Console.Write("Guess the number between 1 and 20: ");
        string userInput = Console.ReadLine();
        x = int.Parse(userInput);
        if (number > x)
        {
            Console.WriteLine("The number is higher, try again");
        }

        if (number < x)
        {
            Console.WriteLine("The number is lower, try again");
        }
        }
        Console.WriteLine($"Congratulations! The number was {number}");
    }
}