//Print Array Elements:
//Write a C# program that stores elements in an array and prints them.
//Test Data: Input 10 elements in the array: 1, 1, 2, 3, 4, 5, 6, 7, 8, 9.
//Expected Output: Elements in the array are: 1 1 2 3 4 5 6 7 8 9.

using System;

namespace parcticalTasksForArrays
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Array customArray = Array.CreateInstance(typeof(string), 10);
            Console.WriteLine("Please enter 10 elements for you array");
            for (int i = 0; i < customArray.Length; i++)
            {
                customArray.SetValue(Console.ReadLine(), i);
            }
            Console.WriteLine("Elements in the array are: ");
            foreach (string i in customArray)
            {
                Console.Write(i + " ");
            }

        }
    }
}