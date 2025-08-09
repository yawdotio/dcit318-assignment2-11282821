using System;

// This code demonstrates the use of inheritance. Task 1.

using System;

// This code demonstrates the abstract classees in C#.

// Abstract class Shape with abstract method GetArea()
public abstract class Shape
{
    public abstract double GetArea();
}

// Circle class implementing GetArea()
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class implementing GetArea()
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}


