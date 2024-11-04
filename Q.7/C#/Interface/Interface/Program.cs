using System;

namespace MultipleInterfaceExample
{
    // Define the first interface
    public interface IAnimal
    {
        void Eat();
    }

    // Define the second interface
    public interface IPet
    {
        void Play();
    }

    // Implement multiple interfaces in a class
    public class Dog : IAnimal, IPet
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Play()
        {
            Console.WriteLine("Dog is playing.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Play();

            // Polymorphism: Using interface references
            IAnimal animal = myDog;
            animal.Eat();

            IPet pet = myDog;
            pet.Play();

            Console.ReadLine();
        }
    }
}
