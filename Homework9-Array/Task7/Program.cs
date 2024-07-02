//Merge Sorted Arrays:
//Merge two arrays of the same size sorted in ascending order.
//Test Data:
//First array: 1, 2, 3.
//Second array: 1, 2, 3.
//Expected Output: The merged array in ascending order: 1 1 2 2 3 3.

using System;

namespace MergeSortedArrays
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 elements for the first array");
            int[] firstInputArray = new int[5];
            for (int i = 0; i < firstInputArray.Length; i++)
            {
                firstInputArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter 5 elements for the second array");
            int[] secondInputArray = new int[5];
            for (int i = 0; i < secondInputArray.Length; i++)
            {
                secondInputArray[i] = int.Parse(Console.ReadLine());
            }

            //declaring new array
            Console.WriteLine("The result is:");

            int[] resultArray = new int[firstInputArray.Length + secondInputArray.Length];

            resultArray = firstInputArray.Union(secondInputArray).ToArray();
            Array.Sort(resultArray);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }

        }
    }
}