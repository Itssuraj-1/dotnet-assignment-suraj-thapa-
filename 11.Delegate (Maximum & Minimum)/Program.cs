// Q11: Create a delegate that refers to methods returning the maximum and minimum of two numbers.
using System;

namespace LabQuestions
{
    // Delegate declaration
    delegate int Calculate(int a, int b);

    class Q11_Delegate
    {
        static int Maximum(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static int Minimum(int a, int b)
        {
            return (a < b) ? a : b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Delegate pointing to Maximum method
            Calculate calcMax = Maximum;
            Console.WriteLine("Maximum: " + calcMax(num1, num2));

            // Delegate pointing to Minimum method
            Calculate calcMin = Minimum;
            Console.WriteLine("Minimum: " + calcMin(num1, num2));

            Console.ReadKey();
        }
    }
}