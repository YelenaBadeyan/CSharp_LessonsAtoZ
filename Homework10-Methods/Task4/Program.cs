using System;

namespace CalculateAverageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average;

            bool result = CalculateAverageWithOut(numbers, out average);

            if (result)
            {
                Console.WriteLine($"The average value of the array is: {average}");
            }
            else
            {
                Console.WriteLine("The array is empty.");
            }
        }

        static bool CalculateAverageWithOut(int[] array, out double average)
        {
            if (array == null || array.Length == 0)
            {
                average = 0;
                return false;
            }

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            average = (double)sum / array.Length;
            return true;
        }
    }
}