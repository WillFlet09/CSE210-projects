class BreathingActivity : Activity{

    public BreathingActivity(string name, string description, int seconds)
    :base(name, description, seconds)
    {
        
    }

    public void RunActivity()
    {
        DisplayGreeting();
        Thread.Sleep(1000);
        DisplayDescription();
        Console.Write("How long in seconds would you like to do the activity? ");
        _timer = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        DisplaySpinner();
        Thread threadtimer = new Thread(new ThreadStart(() => StartTime()));
        _endTime = false;
        threadtimer.Start();
        Console.Clear();
        while(_endTime == false)
        {
            Console.Write("Breathe in...4");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("3");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("2");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("1");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Breathe out...6");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("5");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("4");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("3");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("2");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("1");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Clear();
        }
        threadtimer.Join();
        DisplayEnding();
    }
}