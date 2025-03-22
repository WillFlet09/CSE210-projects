class ReflectionActivity : Activity{
    public ReflectionActivity(string name, string description, int seconds)
    :base(name, description, seconds){
        _name = "Reflection Activity";
    }

    protected List<string> _Prompt = new List<string>
    {
        
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."

    };

    protected List<string> _Questions = new List<string>
    {
        
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"

    };

    public void RunActivity()
    {
        DisplayGreeting();
        Thread.Sleep(1000);
        DisplayDescription();
        Console.Write("How long in seconds would you like to do the activity? ");
        _timer = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1500);
        Random rand = new Random();
        int _prompt = rand.Next(1, _Prompt.Count());
        int _question = rand.Next(1, _Questions.Count());
        Console.WriteLine(_Prompt[_prompt]);
        DisplaySpinner();
        Console.WriteLine(_Questions[_question]);
        Thread threadtimer = new Thread(new ThreadStart(() => StartTime()));
        _endTime = false;
        threadtimer.Start();
        while(_endTime == false)
        {
            DisplaySpinner();
        }
        Console.Clear();
        threadtimer.Join();
        DisplayEnding();
    }
}