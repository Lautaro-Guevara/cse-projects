using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Rectangle("Blue", 3, 5),
            new Circle("Green", 2)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"A {shape.GetColor()} shape with area {shape.GetArea()}");
        }
    }
}