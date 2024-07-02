using System;

namespace StringConcatenationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            string string3 = "How";
            string string4 = "are";
            string string5 = "you";

            string concatenatedStringWithSpace = string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5;
            Console.WriteLine("Concatenated string with spaces: " + concatenatedStringWithSpace);

            string concatenatedStringWithComma = string1 + ", " + string2 + ", " + string3 + ", " + string4 + ", " + string5;
            Console.WriteLine("Concatenated string with commas: " + concatenatedStringWithComma);

            string concatenatedUsingJoinWithSpace = string.Join(" ", string1, string2, string3, string4, string5);
            Console.WriteLine("Concatenated using String.Join with spaces: " + concatenatedUsingJoinWithSpace);

            string concatenatedUsingJoinWithComma = string.Join(", ", string1, string2, string3, string4, string5);
            Console.WriteLine("Concatenated using String.Join with commas: " + concatenatedUsingJoinWithComma);
        }
    }
}
