using System;

namespace PyramidPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for the user's input
            Console.Write("Enter the number of levels for the pyramid: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int N) && N > 0)
            {
                // Print the pyramid pattern
                Console.WriteLine($"Pyramid pattern with {N} levels:");
                for (int i = 1; i <= N; i++)
                {
                    // Print spaces for alignment
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }

                    // Print stars
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine(); // Move to the next line after each level
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}