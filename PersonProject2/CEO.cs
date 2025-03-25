class CEO : Person{

    private string _business;
    public CEO(string business, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _business = business;
    }

    public string GetCEOInfo()
    {
        return $"{GetPersonInfo()}, {_business}";
    }

    public override string GetName()
    {
        return $"CEO {base.GetName()}";
    }
}