using System;
using System.Net;

class Journal{

    public List<string> _Questions = new List<string>
    {
        "What was the best food you ate today?", "What was the best interaction you had with someone today?", "Any particular media you listened to, read, watched, or played today of note?", "What is your favorite and least favorite class today?", "How have you seen the lord in your life recently?"
    }; 
    public void _ReadFromFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
 
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
 
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
 
            Entry entry = new Entry(date, prompt, response);  
            this._Entries.Add(entry);
        }
    }
    public void _WriteFromFile()
    {
        Random _rand = new Random();
        int question = _rand.Next(0,_Questions.Count);
        string prompt = _Questions[question];
        Console.WriteLine($"{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        _Entries.Add(new Entry(prompt, response, date));
        


    }

    public void _WriteToFile()
    {
        Console.Write("What is the file you are saving it to? ");
        string filename = Console.ReadLine();
        string filepath = $"./{filename}";

        using (StreamWriter outputFile = new StreamWriter(filepath, true))
        {
            foreach(Entry entry in _Entries)
            {
                string date = entry.GetDate();
                string prompt = entry.GetPrompt();
                string response = entry.GetResponse();
                outputFile.WriteLine($"{date}#{prompt}#{response}");
            }           
        }
    }

    public List<Entry> _Entries = new List<Entry>();

    public void _DisplayJournal()
    {
        foreach(Entry entry in _Entries)
        {
            string prompt = entry.GetPrompt();
            string date = entry.GetDate();
            string response = entry.GetResponse();
            Console.WriteLine($"{date}, {prompt}: {response}");
        }
        Console.ReadKey();
    }


}