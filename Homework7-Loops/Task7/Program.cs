using System;

namespace SumOfEvenDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfEvenDigits = 0;

            int temp = Math.Abs(number);
            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit % 2 == 0)
                {
                    sumOfEvenDigits += digit;
                }
                temp /= 10;
            }

            Console.WriteLine($"The sum of even digits in {number} is {sumOfEvenDigits}.");
        }
    }
}