using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your year of birth: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int yearOfBirth))
            {

                int currentYear = DateTime.Now.Year;

                int age = currentYear - yearOfBirth;

                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid year of birth entered. Please enter a valid year.");
            }
        }
    }
}