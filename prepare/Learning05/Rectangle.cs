using System;

public class Rectangle : Shape
{
    private double _width;
    private double _length;
    private string _color;

    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}