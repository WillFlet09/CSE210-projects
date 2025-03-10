using System;
using System.Security.Cryptography;

class Fraction
{
    private int _top;
    private int _bottom;

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetFractionString()
    {
        string frac = ($"{_top}/{_bottom}");
        Console.WriteLine($"{frac}");
    }

    public void GetDecimalValue()
    {
        double deci = (double)_top/(double)_bottom;
        Console.WriteLine($"{deci}");
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

}