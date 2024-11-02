using System;

namespace MultiLevelInheritance
{
    // Base class (parent)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Intermediate class
    class Mammal : Animal
    {
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }

    // Derived class (child)
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();  // Calling method from base class
            dog.Walk(); // Calling method from intermediate class
            dog.Bark(); // Calling method from derived class
            Console.ReadLine();
        }
    }
}
