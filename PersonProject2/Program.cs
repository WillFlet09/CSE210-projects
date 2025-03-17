class Program{

    public static void Main(string[] args)
    {
        Person myperson = new Person("Perry", "Ryder", 18);

        Console.WriteLine($"{myperson.DisplayPersonInfo()}");

        PoliceMan myPoliceMan = new PoliceMan("Desert Eagle", "Tim", "Walker", 26);

        Console.WriteLine($"{myPoliceMan.DisplayPoliceManInfo()}");

        CEO myCEO = new CEO("Cola Inc.", "Rufus", "Herrins", 48);

        Console.WriteLine($"{myCEO.DisplayCEOInfo()}");
    }
}



