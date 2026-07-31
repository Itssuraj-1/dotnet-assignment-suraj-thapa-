// Q1: Display the grade of a student based on percentage using else if ladder.
using System;

namespace LabQuestions
{
    class Q1_Grade
    {
        static void Main(string[] args)
        {
            Console.Write("Enter percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            if (percentage >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }

            Console.ReadKey();
        }
    }
}