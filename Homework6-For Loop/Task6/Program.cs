using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer N: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int N) && N >= 0)
            {
                int factorial = 1;
                for (int i = 2; i <= N; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"Factorial of {N} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }
    }
}