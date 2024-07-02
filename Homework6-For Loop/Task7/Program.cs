using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci numbers to generate (N >= 1): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int N) && N >= 1)
            {
                int a = 0, b = 1;
                Console.Write($"Fibonacci sequence of {N} numbers: ");

                if (N >= 1)
                {
                    Console.Write($"{a} ");
                }

                if (N >= 2)
                {
                    Console.Write($"{b} ");
                }

                for (int i = 3; i <= N; i++)
                {
                    int next = a + b;
                    Console.Write($"{next} ");
                    a = b;
                    b = next;
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer N >= 1.");
            }
        }
    }
}