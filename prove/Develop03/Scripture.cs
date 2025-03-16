using System;
using System.Text.RegularExpressions;

class Scripture{
    private List<Word> _Words = new List<Word>();

    private Reference _reference;

    private string _text;

    private string _name;

    private int _chapter;

    private int[] _verse = [0, 0];

    public Scripture(string name, int chapter, int verse, string text)
    {
        this._name = name;
        this._chapter = chapter;
        this._verse[0] = verse;
        this._text = text;
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        this._name = name;
        this._chapter = chapter;
        this._verse[0] = startVerse;
        this._verse[1] = endVerse;
        this._text = text;
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
         string[] wordList = text.Split(' ');
         for(int i = 0; i < wordList.Count(); i++)
         {
            _Words.Add(new Word(wordList[i]));
            int wordlength = _Words[i].GetWordLength();
            
         }
         Console.WriteLine($"{text}");
         
    }

    public void HideSomeWords()
    {
        Random r1 = new Random();
        Random r2 = new Random();
        Random r3 = new Random();
        int i = _Words.Count();
        
        int hide1 = r1.Next(0,i);
        int hide2 = r2.Next(0,i);
        int hide3 = r3.Next(0,i);

        string word1 = _Words[hide1].GetWord();
        string word2 = _Words[hide2].GetWord();
        string word3 = _Words[hide3].GetWord();
        int index = 0;
        while(hide1 == hide2 || hide1 == hide3 || hide2 == hide3 || word1.Contains('_') || word2.Contains('_') || word3.Contains('_') || word1.Contains('\n') || word2.Contains('\n') || word3.Contains('\n'))
        {
            hide1 = r1.Next(0,i);
            hide2 = r2.Next(0,i);
            hide3 = r3.Next(0,i);
            if(index > _Words.Count() * 10000)
            {
                break;
            }
            index++;
            
        }
        word1 = _Words[hide1].GetWord();
        word2 = _Words[hide2].GetWord();
        word3 = _Words[hide3].GetWord();

        _Words[hide1].SetIsHidden(true);
        _Words[hide2].SetIsHidden(true);
        _Words[hide3].SetIsHidden(true);

        _reference.ShowScriptureReference();
        for(int j = 0; j < i; j++)
        {
            if(_Words[j].GetIsHidden() == true)
            {
                string replace1 = Regex.Replace(_Words[j].GetWord(),@"([a-zA-Z])", "_"); 
                Console.Write(replace1 + " ");
            } else{
                Console.Write(_Words[j].GetWord() + " ");
            }
        }
        Console.WriteLine();
    }
}