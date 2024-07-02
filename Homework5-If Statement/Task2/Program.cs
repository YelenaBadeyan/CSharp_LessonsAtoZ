using System;

namespace IfElseStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
