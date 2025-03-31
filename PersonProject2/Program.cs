class Program{

    public static void Main(string[] args)
    {
        // Person myperson = new Person("Perry", "Ryder", 18);
        // Console.WriteLine($"{myperson.GetPersonInfo()}");
        // myperson.SetHeight(68);
        // Console.WriteLine($"Height: {myperson.GetHeight()} inches");

        PoliceMan myPoliceMan = new PoliceMan("Desert Eagle", "Tim", "Walker", 26);
        // Console.WriteLine($"{myPoliceMan.GetPoliceManInfo()}");
        // myPoliceMan.SetHeight(71);
        // Console.WriteLine($"Height: {myPoliceMan.GetHeight()} inches");
        // Console.WriteLine($"{myPoliceMan.GetName()}");

        CEO myCEO = new CEO("Cola Inc.", "Rufus", "Herrins", 42);
        // Console.WriteLine($"{myCEO.GetCEOInfo()}");
        // myCEO.SetHeight(70);
        // Console.WriteLine($"Height: {myCEO.GetHeight()} inches");
        // Console.WriteLine($"{myCEO.GetName()}");

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myperson);
        myPeople.Add(myPoliceMan);
        myPeople.Add(myCEO);

        foreach(Person person in myPeople)
        {
            Console.WriteLine($"{person.GetName()}");
        }
    }
}



