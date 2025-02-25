using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Hello CSE 210");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}");
        Console.WriteLine("What is your quest?");
        string quest = Console.ReadLine();
        Console.WriteLine($"{quest}");
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"{color}");
    }
}