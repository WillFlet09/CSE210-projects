using System;

class Entry{

    private string _prompt;

    private string _response;
    private string _date;

    public Entry(string Date, string Prompt, string Response)
    {
        this._prompt = Prompt;
        this._response = Response;
        this._date = Date;
    }

    public string GetPrompt()
    {
        return this._prompt;
    }

    public string GetResponse()
    {
        return this._response;
    }
    
    public string GetDate()
    {
        return this._date;
    }
}