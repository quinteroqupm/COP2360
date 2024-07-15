using System;

namespace InheritanceExample
{
    // Base class (parent)
    public class Animal
    {
        // Field
        public string Name;

        // Constructor
        public Animal(string name)
        {
            Name = name;
        }

        // Method
        public void Display()
        {
            Console.WriteLine($"I am an animal and my name is {}");
        }
        
        // Virtual method for overriding
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }

    // Deriver class (child)
    public class Dog : Animal
    {
        // Additional field for Dog class
        public string Breed;

        // Constructor that calls the base class constructor
        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        // Override the Speak method
        public override void Speak()
        {
            Console.Write.Line("Woof! Woof!");
        }

        // New method specific to Dog class
        public void DisplayBreed()
        {
            Console.WriteLine($"I am a {Breed}");
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
            // Create an instance of the base class
            Animal animal = new Animal("Generic Animal");
            animal.Display();
            animal.Speak();

            // Create an instance of the derived class
            Dog dog = new Dog("Buddy", "Golden Retriever");
            dog.Display();
            dog.Speak();
            dog.DisplayBreed();

            Console.ReadLine();
        }
    }
}