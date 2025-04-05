using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2025,04,25,09,15,0);
        Address address1 = new Address("415 university avenue", "Rexburg", "Idaho", "US");
        Lecture lecture = new Lecture("The subatomic atom", "The recent scientific breakthrough that found us the subatomic atom join Mr. Thindleberry as he explains the process.", date1, address1, "Leroy Thindleberry", 500);

        DateTime date2 = new DateTime(2025,05,10,11,30,0);
        Address address2 = new Address("Hyrum's Atrium, 170 2nd street", "Rexburg", "Idaho", "US");
        Reception reception = new Reception("Sarah Walker and Matthew Ryder's reception", "Join us this weekend to see Sarah and Matthew Ryder come together in the bonds of holy matrimony. Cake will also be served.\n All are invited on the RSVP", date2, address2, "SarahW234@MahMail.com");

        DateTime date3 = new DateTime(2025,5,15,13,45,0);
        Address address3 = new Address("340 Bob's road", "Rexburg", "Idaho", "US");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Pool Party round back", "We've got a community pool party at our lake in the backyard, bring your family. No college student allowed.", date3, address3, "70 degrees fahrenheit and sunny");

        Console.WriteLine("Welcome to the event program! There are three main events we have in our docket at the moment.");

        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDescription();
        Console.WriteLine(" ");
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDescription();
        Console.WriteLine("");
        outdoorGathering.StandardDetails();
        outdoorGathering.FullDetails();
        outdoorGathering.ShortDescription();

    }
}