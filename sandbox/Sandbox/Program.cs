using System;

class Program
{
    public static int AddNumbers(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        bool correctInput;
        do
        {
        Console.Write("Please input your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >=0 && age < 120)
        {
            Console.WriteLine($"Your age is: {age}");
            correctInput = true;
        } 
        else 
            correctInput = false;
        } while(!correctInput);

        Random newRandomNumber = new Random();
        for(int i = 0; i < 100; i++)
        {
            int number = newRandomNumber.Next(1, 1000);
            Console.WriteLine($"{i}: {number}");
        }
    
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
        //beanitos


        List<int> numbers = new List<int>{1,2,3,4,5,6,7,8};
        numbers.Add(10);

        foreach(int x in numbers)
        {
            Console.WriteLine(x);
        }

        int total = AddNumbers(100, 200);
        Console.WriteLine($"{total}");
    }
}