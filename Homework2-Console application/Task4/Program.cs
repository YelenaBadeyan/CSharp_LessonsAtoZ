using System;

namespace YearOfBirthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int currentYear = DateTime.Now.Year;

                int yearOfBirth = currentYear - age;
                Console.WriteLine($"You were born in {yearOfBirth}.");
            }
            else
            {
                Console.WriteLine("Invalid age entered. Please enter a valid age.");
            }
        }
    }
}