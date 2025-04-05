class Reception:Event
{
    private string _email;
    public Reception(string title, string description, DateTime date, Address address, string email)
    :base(title, description,date,address)
    {
        _email = email;
    }
    public void FullDetails()
    {
        Console.WriteLine("Full Details: ");
        Console.WriteLine($"{GetTitle()} \nDescription: {GetDescription()} this will be held at: {GetDate()} \nAddress {GetAddress()} \nEmail us for an RSVP at: {_email}");
    }
}