using System;

namespace FindMaximumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 7, 3, 7, 7, 2 };
            int maxValue;

            int count = FindMaximumWithOut(numbers, out maxValue);

            if (count > 0)
            {
                Console.WriteLine($"The maximum value in the array is: {maxValue}");
                Console.WriteLine($"The maximum value appears {count} times in the array.");
            }
            else
            {
                Console.WriteLine("The array is empty.");
            }
        }

        static int FindMaximumWithOut(int[] array, out int maxValue)
        {
            if (array == null || array.Length == 0)
            {
                maxValue = default(int);
                return 0;
            }

            maxValue = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    count = 1;
                }
                else if (array[i] == maxValue)
                {
                    count++;
                }
            }

            return count;
        }
    }
}