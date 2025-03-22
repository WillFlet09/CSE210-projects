class ListingActivity : Activity{
    public ListingActivity(string name, string description, int seconds)
    :base(name, description, seconds){
    }

    List<string> _Prompt = new List<string>
    {
        
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"

    }; 
    public void RunActivity()
    {
        DisplayGreeting();
        Thread.Sleep(1000);
        DisplayDescription();
        Console.Write("How long in seconds would you like to do the activity? ");
        _timer = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        DisplaySpinner();
        Random rand = new Random();
        int _prompt = rand.Next(1, _Prompt.Count());
        Console.WriteLine(_Prompt[_prompt]);
        Thread threadtimer = new Thread(new ThreadStart(() => StartTime()));
        _endTime = false;
        threadtimer.Start();
        while(_endTime == false)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.Clear();
        threadtimer.Join();
        DisplayEnding();

    }

    private void SetPrompts()
    {

    }

    private void ResetPromptsUsage(){

    }
    
}