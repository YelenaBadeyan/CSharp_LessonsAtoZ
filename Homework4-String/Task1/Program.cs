using System;

namespace BasicStringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = "Hello, World!";

            int lengthOfString = originalString.Length;
            Console.WriteLine("Length of the string: " + lengthOfString);

            string upperCaseString = originalString.ToUpper();
            Console.WriteLine("String in uppercase: " + upperCaseString);

            string lowerCaseString = originalString.ToLower();
            Console.WriteLine("String in lowercase: " + lowerCaseString);

            int startIndex = originalString.IndexOf("World");
            string substring = originalString.Substring(startIndex, "World".Length);
            Console.WriteLine("Extracted substring: " + substring);

        }
    }
}
