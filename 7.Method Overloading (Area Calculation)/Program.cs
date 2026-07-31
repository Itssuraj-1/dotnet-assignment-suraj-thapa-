// Q7: Write a program demonstrating method overloading for calculating area of different shapes.
using System;

namespace LabQuestions
{
    class AreaCalculator
    {
        // Area of a square
        public double Area(double side)
        {
            return side * side;
        }

        // Area of a rectangle
        public double Area(double length, double width)
        {
            return length * width;
        }

        // Area of a circle (using one double parameter, so use a bool flag to differentiate from square)
        public double Area(double radius, bool isCircle)
        {
            return Math.PI * radius * radius;
        }

        // Area of a triangle
        public double Area(double baseLength, double height, string shape)
        {
            if (shape.ToLower() == "triangle")
                return 0.5 * baseLength * height;
            return 0;
        }
    }

    class Q7_MethodOverloading
    {
        static void Main(string[] args)
        {
            AreaCalculator calc = new AreaCalculator();

            Console.WriteLine("Area of square (side=4): " + calc.Area(4));
            Console.WriteLine("Area of rectangle (l=4, w=6): " + calc.Area(4, 6));
            Console.WriteLine("Area of circle (radius=3): " + calc.Area(3, true));
            Console.WriteLine("Area of triangle (base=5, height=8): " + calc.Area(5, 8, "triangle"));

            Console.ReadKey();
        }
    }
}