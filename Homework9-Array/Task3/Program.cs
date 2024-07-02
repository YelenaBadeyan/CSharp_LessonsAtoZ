//Sum of Array Elements:
//Find the sum of all elements in an array.
//Test Data: Input 3 elements in the array: 2, 5, 8.
//Expected Output: Sum of all elements stored in the array is: 15.

using System;

namespace sumOfArrayElements
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] customArray = new int[3];
            Console.WriteLine("Please enter 3 elements for your array");

            for (int i = 0; i < customArray.Length; i++)
            {
                customArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < customArray.Length; i++)
            {
                sum += customArray[i];
            }

            Console.WriteLine("Sum of array elements is: " + sum);
        }
    }
}