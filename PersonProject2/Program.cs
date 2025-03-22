class Program{

    public static void Main(string[] args)
    {
        Person myperson = new Person("Perry", "Ryder", 18);
        Console.WriteLine($"{myperson.DisplayPersonInfo()}");
        myperson.SetHeight(68);
        Console.WriteLine($"Height: {myperson.GetHeight()} inches");

        PoliceMan myPoliceMan = new PoliceMan("Desert Eagle", "Tim", "Walker", 26);
        Console.WriteLine($"{myPoliceMan.DisplayPoliceManInfo()}");
        myPoliceMan.SetHeight(71);
        Console.WriteLine($"Height: {myPoliceMan.GetHeight()} inches");

        CEO myCEO = new CEO("Cola Inc.", "Rufus", "Herrins", 48);
        Console.WriteLine($"{myCEO.DisplayCEOInfo()}");
        myCEO.SetHeight(70);
        Console.WriteLine($"Height: {myCEO.GetHeight()} inches");
    }
}



