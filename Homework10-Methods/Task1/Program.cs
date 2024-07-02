using System;

namespace FindMinimumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 4.5, 2.3, 6.7, 1.2, 9.8 };
            double minValue;

            bool result = FindMinimumWithOut(numbers, out minValue);

            if (result)
            {
                Console.WriteLine($"The minimum value in the array is: {minValue}");
            }
            else
            {
                Console.WriteLine("The array is empty.");
            }
        }

        static bool FindMinimumWithOut(double[] array, out double minValue)
        {
            if (array == null || array.Length == 0)
            {
                minValue = default(double);
                return false;
            }

            minValue = array[0];
            foreach (double num in array)
            {
                if (num < minValue)
                {
                    minValue = num;
                }
            }
            return true;
        }
    }
}
