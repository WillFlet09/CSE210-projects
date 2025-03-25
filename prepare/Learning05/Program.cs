using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _Shapes = new List<Shape>();
        Square square1 = new Square(5, "Blue");
        _Shapes.Add(square1);
        Rectangle rectangle1 = new Rectangle(5,8,"Red");
        _Shapes.Add(rectangle1);
        Circle circle1 = new Circle(9,"Green");
        _Shapes.Add(circle1);

        foreach(Shape shape in _Shapes)
        {
            Console.WriteLine($"{shape} \nColor: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}