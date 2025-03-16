using System;

class Word{
    private string _word;

    public Word(string text)
    {
        this._word = text;
    }

    private bool isHidden;

    public bool GetIsHidden()
    {
        return this.isHidden;
    }

    public void SetIsHidden(bool hidden)
    {
        this.isHidden = hidden;
    }

    public string GetWord()
    {
        return this._word;
    }

    public void SetWord(string word)
    {
        this._word = word;
    }


    // public string GetWordString()
    // {
        
    // }

    public int GetWordLength()
    {
        return _word.Count();
    }
}