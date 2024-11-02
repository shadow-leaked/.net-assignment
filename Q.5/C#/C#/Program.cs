using System;

namespace ConstructorExample
{
    // Define the class with constructors
    class Car
    {
        public string brand;
        public string model;
        public int year;

        // Default constructor
        public Car()
        {
            brand = "Unknown";
            model = "Unknown";
            year = 0;
        }

        // Parameterized constructor
        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        // Method to display car details
        public void DisplayDetails()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance using the default constructor
            Car defaultCar = new Car();
            defaultCar.DisplayDetails();

            // Create an instance using the parameterized constructor
            Car myCar = new Car("Toyota", "Corolla", 2022);
            myCar.DisplayDetails();

            Console.ReadLine();
        }
    }
}
