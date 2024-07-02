using System;

namespace NumberClassificationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
