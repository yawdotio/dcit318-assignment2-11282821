using System;

// This code demonstrates the use of inheritance and method overriding in C#.

// Define the IMovable interface
public interface IMovable
{
    void Move();
}

// Car class implementing IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class implementing IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}


