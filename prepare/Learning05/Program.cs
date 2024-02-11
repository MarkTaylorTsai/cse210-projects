using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 2.5),
            new Rectangle("Blue", 4.0, 3.0),
            new Circle("Green", 1.5)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}