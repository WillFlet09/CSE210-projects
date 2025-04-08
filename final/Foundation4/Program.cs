using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2025,04,25);
        Activity activity = new Activity(date1,60);
        Swimming swimming = new Swimming(date1,20,5,4);
        activity._Activites.Add(swimming);
        DateTime date2 = new DateTime(2025,03,31);
        Cycling cycling = new Cycling(date2,9,55);
        activity._Activites.Add(cycling);
        Running running = new Running(date2,30,6);
        activity._Activites.Add(running);
        activity.ListIterate();
        
        
        
    }
}