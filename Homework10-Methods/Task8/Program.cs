using System;

namespace FibonacciExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the position of the Fibonacci number you want to calculate: ");
            int n = int.Parse(Console.ReadLine());

            int fibonacciNumber = Fibonacci(n);

            Console.WriteLine($"The {n}th Fibonacci number is: {fibonacciNumber}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}