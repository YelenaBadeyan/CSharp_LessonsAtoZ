using System;

namespace CountOccurrencesOfCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Please enter a character to count: ");
            char characterToCount = Console.ReadLine()[0];

            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == characterToCount)
                {
                    count++;
                }
            }

            Console.WriteLine($"The character '{characterToCount}' appears {count} times in the string.");
        }
    }
}