using System;

namespace NestedIfWithMultipleConditionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 7;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The largest number is: " + a);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The largest number is: " + b);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
        }
    }
}
