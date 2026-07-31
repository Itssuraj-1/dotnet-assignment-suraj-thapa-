// Q8: Create a base class Vehicle and derived classes Car and Bike. Show inheritance.
using System;

namespace LabQuestions
{
    class Vehicle
    {
        public string Brand;

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public void DisplayBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }

        public void Start()
        {
            Console.WriteLine(Brand + " vehicle is starting...");
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors;

        public Car(string brand, int doors) : base(brand)
        {
            NumberOfDoors = doors;
        }

        public void DisplayCarInfo()
        {
            DisplayBrand();
            Console.WriteLine("Number of doors: " + NumberOfDoors);
        }
    }

    class Bike : Vehicle
    {
        public bool HasGear;

        public Bike(string brand, bool hasGear) : base(brand)
        {
            HasGear = hasGear;
        }

        public void DisplayBikeInfo()
        {
            DisplayBrand();
            Console.WriteLine("Has gear: " + HasGear);
        }
    }

    class Q8_Inheritance
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 4);
            Bike myBike = new Bike("Yamaha", true);

            Console.WriteLine("--- Car Info ---");
            myCar.Start();
            myCar.DisplayCarInfo();

            Console.WriteLine("\n--- Bike Info ---");
            myBike.Start();
            myBike.DisplayBikeInfo();

            Console.ReadKey();
        }
    }
}