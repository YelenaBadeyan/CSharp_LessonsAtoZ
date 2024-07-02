using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            int guess = 0;
            bool correctGuess = false;

            Console.WriteLine("Guess the number between 1 and 100!");

            while (!correctGuess)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        correctGuess = true;
                        Console.WriteLine("Congratulations! You guessed the correct number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
        }
    }
}