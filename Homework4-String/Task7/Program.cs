using System;

namespace TrimmingStringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = " Hello, World! ";

            string trimmedString = originalString.Trim();

            Console.WriteLine("Original string: '" + originalString + "'");
            Console.WriteLine("Trimmed string: '" + trimmedString + "'");
        }
    }
}
