class OutdoorGathering:Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, DateTime date, Address address, string weather)
    :base(title, description, date, address)
    {
        _weather = weather;
    }
    public void FullDetails()
    {
        Console.WriteLine("Full Details: ");
        Console.WriteLine($"Title: {GetTitle()} \nDescription: {GetDescription()} \nDate: {GetDate()} \nAddress:{GetAddress()} \nThe Weather is: {_weather}");
    }
}