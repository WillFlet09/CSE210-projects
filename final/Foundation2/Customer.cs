class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = new Address(address.GetStreetAddress(), address.GetCity(), address.GetState(), address.GetCountry());
    }

    public bool IsAmerican()
    {
        string citzenship = _address.GetCountry();
        bool _isAmerican = false;
        if(citzenship == "US")
        {
            _isAmerican = true;
            return _isAmerican;
        }
        return _isAmerican;
    }

    public string GetAddress()
    {
        return _address.ToString();
    }
    public string GetName()
    {
        return _name;
    }
    
}