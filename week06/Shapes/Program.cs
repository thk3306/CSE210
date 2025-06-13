using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        Console.WriteLine($"{square.GetColor()}, {square.GetArea()}");

        Circle circle = new Circle("red", 5);
        Console.WriteLine($"{circle.GetColor()}, {circle.GetArea()}");

        Rectangle rectangle = new Rectangle("blue", 4, 4);
        Console.WriteLine($"{rectangle.GetColor()}, {rectangle.GetArea()}");

        List<Shape> shapes = new List<Shape>
        {
            square,
            circle,
            rectangle
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");
        }
        }
    }

