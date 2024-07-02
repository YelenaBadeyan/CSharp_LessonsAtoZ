//Print Unique Elements:
//Print all unique elements in an array.
//Test Data: Input 3 elements in the array: 1, 5, 1.
//Expected Output: The unique elements found in the array are: 5.

using System;
using System.ComponentModel.Design;

namespace UniqueElements
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

            //findiing unique elements from given array
            Console.WriteLine("Unique numbers are:");

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (i != j && inputArray[i] == inputArray[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(inputArray[i]);
                }


            }

        }
    }
}