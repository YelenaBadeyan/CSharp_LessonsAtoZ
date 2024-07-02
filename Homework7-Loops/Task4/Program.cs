using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();

            string lowerCaseString = inputString.ToLower();

            bool isPalindrome = true;

            for (int i = 0; i < lowerCaseString.Length / 2; i++)
            {
                if (lowerCaseString[i] != lowerCaseString[lowerCaseString.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"The string \"{inputString}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The string \"{inputString}\" is not a palindrome.");
            }
        }
    }
}