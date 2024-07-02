using System;

namespace NestedIfStatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 30;

            if (number > 0)
            {
                Console.WriteLine("The number is greater than 0.");

                if (number < 50)
                {
                    Console.WriteLine("The number is less than 50.");
                }
                else
                {
                    Console.WriteLine("The number is 50 or greater.");
                }
            }
            else
            {
                Console.WriteLine("The number is 0 or less.");
            }
        }
    }
}
