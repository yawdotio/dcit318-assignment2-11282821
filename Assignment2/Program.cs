using System.Drawing;

public class Program
{
    public static void Main()
    {
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Task 1: Demonstrating inheritance and method overriding
        // Each animal makes its own sound

        Console.WriteLine("-----------------");
        Console.WriteLine("Animal Sounds:");
        Console.WriteLine("Generic Animal:");
        genericAnimal.MakeSound(); // Output: Some generic sound
        Console.WriteLine("Dog:");
        dog.MakeSound();           // Output: Bark
        Console.WriteLine("Cat:");
        cat.MakeSound();  // Output: Meow


        // Task 2: Demonstrating abstract classes with shapes implementing GetArea()
        Console.WriteLine("-----------------");
        Console.WriteLine("Shapes and areas");
        // Demonstrate Shape, Circle, and Rectangle
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Area of Circle: {circle.GetArea()}"); // Output: Area of Circle: 78.53981633974483
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Output: Area of Rectangle: 24.0

        // Task 3: Demonstrate interfaces using IMovable, Car, and Bicycle
        Console.WriteLine("-----------------");
        Console.WriteLine("Movable Objects:");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();      // Output: Car is moving
        bicycle.Move();  // Output: Bicycle is moving


        Console.WriteLine("-----------------");

    }
}
