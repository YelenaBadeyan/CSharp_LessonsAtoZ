using System;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Please enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("Invalid range: start should be less than or equal to end.");
                return;
            }

            Console.WriteLine($"Even numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}