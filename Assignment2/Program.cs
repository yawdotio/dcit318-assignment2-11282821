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

        Console.WriteLine("Animal Sounds:");
        Console.WriteLine("-----------------");
        Console.WriteLine("Generic Animal:");
        genericAnimal.MakeSound(); // Output: Some generic sound
        Console.WriteLine("Dog:");
        dog.MakeSound();           // Output: Bark
        Console.WriteLine("Cat:");
        cat.MakeSound();  // Output: Meow


    }
}
