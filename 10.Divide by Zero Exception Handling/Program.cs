// Q10: Write a program to handle divide-by-zero exceptions.
using System;

namespace LabQuestions
{
    class Q10_DivideByZero
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.ReadKey();
        }
    }
}