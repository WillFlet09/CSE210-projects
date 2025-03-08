using System;
class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public void DisplayCircleArea()
    {
        Console.WriteLine($"The Area of the circle is:{GetArea()}");
    }

    public void SetRadius(double r)
    {
        r = radius;
    }
}
class CircleProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Good Morning USA");

        //double x = 10;
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Cylinder myCyilinder = new Cylinder(10, myCircle);
        double volume = myCyilinder.GetVolume();
        Console.WriteLine($"The cylinder volume is: {volume}");
        
    }
}