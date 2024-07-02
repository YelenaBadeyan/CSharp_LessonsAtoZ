//Frequency of Each Element:
//Count the frequency of each element in an array.
//Test Data: Input 3 elements in the array: 25, 12, 43.
//Expected Output:
//Frequency of all elements of the array:
//25 occurs 1 time.
//12 occurs 1 time.
//43 occurs 1 time.

using System;

namespace MergeSortedArrays
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 elements for the array");
            int[] inputArray = new int[5];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            //find frequency of each element in the given array
            for (int i = 0; inputArray.Length > 0; i++)
            {
                int count = 1;
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (i != j && inputArray[i] == inputArray[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("The count of {0} is {1}", inputArray[i], count);
                count = 1;
            }

        }
    }
}