using System;

namespace Arrays
{
    class MergeArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 5, 4 };
            int[] secondArray = { 1, 5, 7, 8 };
            int[] resultArray = new int[firstArray.Length + secondArray.Length];

            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (indexA < firstArray.Length && (indexB >= secondArray.Length || firstArray[indexA] <= secondArray[indexB]))
                {
                    resultArray[i] = firstArray[indexA];
                    indexA++;
                }
                else
                {
                    resultArray[i] = secondArray[indexB];
                    indexB++;
                }
            }
            Console.WriteLine("Merged Array:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }

            Console.ReadLine();
        }
    }
}