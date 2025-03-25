using System;
using System.Drawing;
using System.Formats.Asn1;

class Rectangle: Shape{
    private double _width;
    private double _length;
    public Rectangle(double width, double length, string color)
    :base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return area;
    }
}