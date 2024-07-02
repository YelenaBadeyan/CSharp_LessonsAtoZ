using System;

namespace SubstringReplacementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = "I love programming in Java";

            string modifiedString = originalString.Replace("Java", "C#");

            Console.WriteLine("Original string: " + originalString);
            Console.WriteLine("Modified string: " + modifiedString);
        }
    }
}
