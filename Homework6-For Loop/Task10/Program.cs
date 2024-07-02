using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for the user's input
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int number))
            {
                // Calculate the sum of digits
                int sum = 0;
                int num = Math.Abs(number); // Ensure positive number for summing digits

                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num /= 10;
                }

                // Print the sum of digits
                Console.WriteLine($"Sum of digits of {number} is: {sum}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter an integer number.");
            }
        }
    }
}