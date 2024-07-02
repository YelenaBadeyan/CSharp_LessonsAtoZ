using System;

namespace StringInterpolationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create variables for personal data
            string name = "Armen";
            int age = 30;
            string profession = ".Net Developer";
            string city = "Ashtarak";
            string hobby = "playing guitar";

            // Step 2: Use string interpolation to create and print a sentence
            string sentence = $"{name} is {age} years old, works as a {profession}, lives in {city}, and enjoys {hobby}.";
            Console.WriteLine(sentence);
        }
    }
}
