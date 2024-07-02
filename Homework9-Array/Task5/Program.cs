//Count Duplicate Elements:
//Count the number of duplicate elements in an array.
//Test Data: Input 3 elements in the array: 5, 1, 1.
//Expected Output: Total number of duplicate elements found in the array is: 1.

using System;

namespace dublicateElements
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 elements for array");
            int count = 0;
            int[] inputArray = new int[5];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("Dublicate elements count is  :" + count);

        }
    }
}