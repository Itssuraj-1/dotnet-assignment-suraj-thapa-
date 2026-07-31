// Q6: Implement constructor overloading in a class Rectangle to initialize dimensions.
using System;

namespace LabQuestions
{
    class Rectangle
    {
        private double length;
        private double width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Constructor with one parameter (square case)
        public Rectangle(double side)
        {
            length = side;
            width = side;
        }

        // Constructor with two parameters
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length = " + length + ", Width = " + width + ", Area = " + GetArea());
        }
    }

    class Q6_ConstructorOverloading
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();          // default
            Rectangle r2 = new Rectangle(5);         // square
            Rectangle r3 = new Rectangle(4, 6);      // rectangle

            Console.WriteLine("Rectangle 1 (default):");
            r1.Display();

            Console.WriteLine("Rectangle 2 (square, side=5):");
            r2.Display();

            Console.WriteLine("Rectangle 3 (length=4, width=6):");
            r3.Display();

            Console.ReadKey();
        }
    }
}