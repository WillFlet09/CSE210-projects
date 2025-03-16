using System;

class Reference{

    private string _bookName;

    private int _chapter;

    private int[] _verse = new int[2];

    public Reference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse[0] = verse;
    }

    public Reference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse[0] = startVerse;
        _verse[1] = endVerse;
    }

    public void ShowScriptureReference()
    {
        Console.WriteLine($"{_bookName} {_chapter}: {_verse[0]}-{_verse[1]}");
    }

    // public string GetReference()
    // {
        
    // }

    // private string GetReferenceString()
    // {
     
    // }
    
}