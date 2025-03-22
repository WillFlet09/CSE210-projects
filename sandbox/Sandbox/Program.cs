using System;
using Microsoft.VisualBasic;

class Program
{
    static void RunSpinner()
    {
        string _name = "Activity";
        int counter = 0;
        Console.WriteLine($"Congratulatious! you completed the {_name}");
        while(counter < 10)
        {
            Console.Write($"\\");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write($"|");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write($"/");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write("-");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write("\\");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write($"|");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write("/");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Write("-");
            Console.Write("\b");
            Thread.Sleep(200);
            Console.Clear();
            counter++;
        }
    }

    static void Main(String[] args)
{
    RunSpinner();
}
}

