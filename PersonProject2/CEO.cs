class CEO : Person{

    private string _business;
    public CEO(string business, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _business = business;
    }

    public string DisplayCEOInfo()
    {
        return $"Info: {DisplayPersonInfo()}, {_business}";
    }
}