using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

class Shape{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string Color)
    {
        _color = Color;
    }

    public virtual double GetArea()
    {
        int area = 2 * 2; 
        return area;
    }
}