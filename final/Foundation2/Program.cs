using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("411 Bob's Rd","Alberquerque", "New Mexico", "US"); 
        Customer customer1 = new Customer("George Steak", address1);
        Order order1 = new Order(customer1);
        order1.GetOrder();
        order1.DisplayLabels();

        Address address2 = new Address("31 Alexander way", "Flin Flon", "Mantiboa", "CA");
        Customer customer2 = new Customer("Tyler Walker", address2);
        Order order2 = new Order(customer2);
        order2.GetOrder();
        order2.DisplayLabels();
    }
}