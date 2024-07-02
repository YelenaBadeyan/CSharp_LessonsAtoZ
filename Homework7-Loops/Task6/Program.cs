using System;

namespace ArmstrongNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int numberOfDigits = 0;
            while (temp > 0)
            {
                temp /= 10;
                numberOfDigits++;
            }

            temp = number;
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }
    }
}