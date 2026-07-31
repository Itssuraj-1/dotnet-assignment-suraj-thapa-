// Q4: Write a program to sort an array of integers in ascending order.
using System;

namespace LabQuestions
{
    class Q4_SortArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter " + n + " integers:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Bubble sort
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array (ascending):");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}