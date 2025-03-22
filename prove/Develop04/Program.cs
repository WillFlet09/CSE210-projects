using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program! We have 3 actvities to choose from to get you mindful");
        int choice = 0;
        while(choice != 4)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Which will You Choose? ");
            choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help your mindfulness through breathing in and out slowly.", 0);
                breathing.RunActivity();
            }

            if(choice == 2)
            {
                ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", "This activity will help your mindfulness through reflection on one of our prompts. Look back on your life and see if this prompt applies", 0);
                reflect.RunActivity();   
            }

            if(choice == 3)
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help your mindfulness through Listing things out in the terminal. From one of our prompts, \nlist things that remind you of the prompt", 0);
                listing.RunActivity();
            } 
        }
    }
}