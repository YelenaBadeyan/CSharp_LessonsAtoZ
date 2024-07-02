using System;

namespace GradeCategorizationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 75;

            if (grade >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
