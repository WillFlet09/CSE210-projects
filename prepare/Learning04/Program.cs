using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment History = new Assignment("Perry Ryder", "World History");
        Console.WriteLine(History.GetSummary());

        MathAssignment Math = new MathAssignment("Problems 14-24", "Section 9", "Rufus Herrins", "Calculus");
        Console.WriteLine(Math.GetSummary());
        Console.WriteLine(Math.GetHomeworkList());

        WritingAssignment Writing = new WritingAssignment("The multiverse and a 1950's detective", "Tim Walker", "English");
        Console.WriteLine(Writing.GetSummary());
        Console.WriteLine(Writing.GetWritingInfo());
    }
}