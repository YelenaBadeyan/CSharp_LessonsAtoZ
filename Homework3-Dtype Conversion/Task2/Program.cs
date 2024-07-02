using System;

namespace ExplicitConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleValue = 42.58;

            int intValue = (int)doubleValue;
            Console.WriteLine("Double variable is: " + doubleValue);
            Console.WriteLine("Int variable after explicit conversion is: " + intValue);
        }
    }
}