using System;

public class Circle : Shape
{
    private double _ratio;
    private double _pi = Math.PI;

    public Circle(string color, double ratio) : base(color)
    {
        _ratio = ratio;
    }

    public override double GetArea()
    {
        return _pi * Math.Pow(_ratio, 2);
    }
}