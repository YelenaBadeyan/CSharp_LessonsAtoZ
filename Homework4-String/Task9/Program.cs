using System;

namespace StringComparisonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "hello";
            string string2 = "HELLO";

            bool areEqualOrdinal = string.Equals(string1, string2, StringComparison.Ordinal);
            Console.WriteLine($"Ordinal comparison: {areEqualOrdinal}");

            bool areEqualOrdinalIgnoreCase = string.Equals(string1, string2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"OrdinalIgnoreCase comparison: {areEqualOrdinalIgnoreCase}");

            bool areEqualInvariantCulture = string.Equals(string1, string2, StringComparison.InvariantCulture);
            Console.WriteLine($"InvariantCulture comparison: {areEqualInvariantCulture}");

            bool areEqualInvariantCultureIgnoreCase = string.Equals(string1, string2, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine($"InvariantCultureIgnoreCase comparison: {areEqualInvariantCultureIgnoreCase}");

            bool areEqualCurrentCulture = string.Equals(string1, string2, StringComparison.CurrentCulture);
            Console.WriteLine($"CurrentCulture comparison: {areEqualCurrentCulture}");

            bool areEqualCurrentCultureIgnoreCase = string.Equals(string1, string2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"CurrentCultureIgnoreCase comparison: {areEqualCurrentCultureIgnoreCase}");
        }
    }
}
