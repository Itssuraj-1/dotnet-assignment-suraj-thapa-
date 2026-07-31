// Q3: Input 10 numbers into an array and find the maximum and minimum values.
using System;

namespace LabQuestions
{
    class Q3_MaxMinArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Minimum value: " + min);

            Console.ReadKey();
        }
    }
}