using System;

namespace ParseAndTryParseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string numericString = "12345";
            int parsedValue = int.Parse(numericString);
            string nonNumericString = "abc123";
            bool success = int.TryParse(nonNumericString, out int tryParsedValue);

            Console.WriteLine("The original numeric string is: " + numericString);
            Console.WriteLine("The converted integer using int.Parse is: " + parsedValue);
            Console.WriteLine("The original non-numeric string is: " + nonNumericString);

        }
    }
}