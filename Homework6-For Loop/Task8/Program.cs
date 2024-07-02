using System;

namespace PrimeNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number of the range: ");
            string startInput = Console.ReadLine();

            Console.Write("Enter the ending number of the range: ");
            string endInput = Console.ReadLine();

            if (int.TryParse(startInput, out int start) && int.TryParse(endInput, out int end))
            {
                if (start < 2)
                {
                    start = 2; 
                }

                Console.WriteLine($"Prime numbers between {start} and {end}:");
                for (int number = start; number <= end; number++)
                {
                    if (IsPrime(number))
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("Invalid input. Please enter valid integers for start and end of the range.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
