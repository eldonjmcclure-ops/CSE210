using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle("red", 7);
        Square square = new Square("blue", 3.7);
        Rectangle rectangle = new Rectangle("green", 6, 4);
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"The area is {area}");
        }

    }
}