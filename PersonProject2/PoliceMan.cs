class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string weapons, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public string DisplayPoliceManInfo()
    {
        return $"Info: {DisplayPersonInfo()}, {_weapons}";
    }
}