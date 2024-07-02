using System;

namespace ComplexNestedIfStatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            bool hasLicense = true;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can drive.");
                }
                else
                {
                    Console.WriteLine("Cannot drive because you don't have a license.");
                }
            }
            else
            {
                Console.WriteLine("Cannot drive because you are under 18.");
            }
        }
    }
}
