using System;

namespace ImplicitConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 42;
            double doubleValue = intValue;

            Console.WriteLine("Int" + intValue);
            Console.WriteLine("Double " + doubleValue);
        }
    }
}