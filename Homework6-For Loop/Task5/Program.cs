using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in input)
            {
                if (Array.Exists(vowels, element => element == c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
        }
    }
}