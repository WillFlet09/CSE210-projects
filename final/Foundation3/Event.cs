using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _eventType = base.ToString();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public DateTime GetDate()
    {
        return _date;
    }

    public string GetAddress()
    {
        string address = _address.ToString();
        return address;
    }

    public void StandardDetails()
    {
        Console.WriteLine("Standard Details: ");
        Console.WriteLine($"Title: {GetTitle()} \nDescription: {GetDescription()} this will be held at {GetDate()} \nAddress: {GetAddress()}");
    }
    public void ShortDescription()
    {
        Console.WriteLine("Short Description: ");
        Console.WriteLine($"Event type: {_eventType}, Title: {_title} Date: {_date}");
    }

}