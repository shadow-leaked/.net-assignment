using System;

namespace SingleLevelInheritance
{
    // Base class (parent)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Derived class (child)
    class Dog : Animal
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
            dog.Bark(); // Calling method from derived class
            Console.ReadLine();
        }
    }
}
