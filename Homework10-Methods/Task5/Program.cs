using System;

namespace ReverseStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine($"Reversed string: {reversed}");
        }

        static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}