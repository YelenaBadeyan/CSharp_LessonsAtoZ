//Reverse Order:
//Read n values in an array and display them in reverse order.
//Test Data: Input the number of elements to store in the array: 3.
//Input 3 numbers: 2, 5, 7.
//Expected Output: The values stored in the array are: 2 5 7.The values in reverse order are: 7 5 2.

using System;

namespace parcticalTasksForArrays
{
    class tasksForArrays
    {
        static void Main(string[] args)
        {
            Array customArray = Array.CreateInstance(typeof(string), 3);
            Console.WriteLine("Please enter 3 velements for you array");
            for (int i = 0; i < customArray.Length; i++)
            {
                customArray.SetValue(Console.ReadLine(), i);
            }
            Array.Reverse(customArray);
            Console.WriteLine("Reversed array elements are");
            foreach (var item in customArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}