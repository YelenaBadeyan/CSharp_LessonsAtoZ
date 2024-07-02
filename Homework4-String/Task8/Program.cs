using System;

namespace NullOrEmptyStringCheckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string nonEmptyString = "Hello, World!";
            string emptyString = "";
            string whitespaceString = "   ";

            Console.WriteLine($"Is nonEmptyString null or empty? {string.IsNullOrEmpty(nonEmptyString)}");
            Console.WriteLine($"Is emptyString null or empty? {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"Is whitespaceString null or empty? {string.IsNullOrEmpty(whitespaceString)}");

            Console.WriteLine($"Is nonEmptyString null or whitespace? {string.IsNullOrWhiteSpace(nonEmptyString)}");
            Console.WriteLine($"Is emptyString null or whitespace? {string.IsNullOrWhiteSpace(emptyString)}");
            Console.WriteLine($"Is whitespaceString null or whitespace? {string.IsNullOrWhiteSpace(whitespaceString)}");
        }
    }
}
