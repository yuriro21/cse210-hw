using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listShapes = new List<Shape>();

        Square shape1 = new Square("Black", 4);
        listShapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 3, 4);
        listShapes.Add(shape2);

        Circle shape3 = new Circle("Orange", 5);
        listShapes.Add(shape3);

        foreach (Shape item in listShapes)
        {
            string color = item.GetColor();
            double area = item.GetArea();
            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}