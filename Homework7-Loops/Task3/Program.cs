using System;

namespace CalculateAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            const int numberOfIntegers = 5;

            Console.WriteLine($"Please enter {numberOfIntegers} integers:");

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            double average = (double)sum / numberOfIntegers;

            Console.WriteLine($"The average of the entered numbers is: {average}");
        }
    }
}