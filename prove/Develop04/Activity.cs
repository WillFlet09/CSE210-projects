
class Activity{
    protected string _name;
    protected string _description;
    protected int _timer;

    protected bool _endTime;

    public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        seconds = _timer;
    }


    public void DisplayGreeting()
    {
        Console.WriteLine($" Welcome to the {this._name}");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(this._description);
    }
    public void DisplayEnding()
    {
        int counter = 0;
        while(counter < 5)
        {
            Console.Write($"Congratulations! You completed the {_name} \\");
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
    public void RunCountDown(){
        
    }
    public void DisplaySpinner()
    {
        int counter = 0;
        while(counter < 5)
        {
            Console.Write("\\");
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
            counter++;
        }
    }
    public void StartTime()
    {
        _timer = _timer * 1000;
        Thread.Sleep(_timer);
        _endTime = true;
    }
    protected int ObtainDuration()
    {
        return _timer;
    }

    

}