// Q5: Accept a string from the user and count how many vowels are present in it.
using System;

namespace LabQuestions
{
    class Q5_CountVowels
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.IndexOf(c) != -1)
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.ReadKey();
        }
    }
}