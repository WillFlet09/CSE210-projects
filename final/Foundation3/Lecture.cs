using System.Reflection;

class Lecture: Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string title, string description, DateTime date, Address address, string speakerName, int capacity):
    base(title, description, date, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        Console.WriteLine("Full Details: ");
        Console.WriteLine($"Speaker: {_speakerName} \nLecture Title: {GetTitle()} \nDescription: {GetDescription()} \nDate: {GetDate()} \nAddress: {GetAddress()} \nCapacity: {_capacity}");
    }
}