using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int x = -1;
        float sum = 0;
        float total = -1;
        float average = 0;
        int maximum = 0;
        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            x = int.Parse(userInput);
            numbers.Add(x);
            if(x > maximum)
            {
                maximum = x;
            }
            total = total + 1;
        } while(x != 0);
        
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + (numbers[i]);
        }
        average = sum / total;
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}