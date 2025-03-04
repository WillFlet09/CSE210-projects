using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Dill Pitcher";

        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Tech Support";
        job1._company = "Waterford High School";
        job1._startYear = 2022;
        job1._endYear = 2023;

        job2._jobTitle = "Cart Pusher";
        job2._company = "Arnold's supermarket";
        job2._startYear = 2023;
        job2._endYear = 2024;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }
}