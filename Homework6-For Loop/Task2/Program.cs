using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer N: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int N) && N > 0)
            {
                int sum = 0;

                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of the first {N} natural numbers is {sum}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}