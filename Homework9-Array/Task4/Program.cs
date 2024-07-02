//Copy Elements to Another Array:
//Copy the elements of one array into another array.
//Test Data: Input 3 elements in the array: 15, 10, 12.
//Expected Output:
//Elements stored in the first array: 15 10 12.
//Elements copied into the second array: 15 10 12.

using System;

namespace copyElementsToAnotherArray
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array elements:");
            int[] inputArray = new int[3];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            int[] copyArray = new int[3];
            Array.Copy(inputArray, copyArray, 3);
            Console.WriteLine("Elements stored in the first array:");
            foreach (int i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Elements copied into the second array:");
            foreach (int i in copyArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}