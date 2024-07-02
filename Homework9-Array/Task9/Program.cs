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
                if (indexA < firstArray.Length && firstArray[indexA] <= secondArray[indexB])
                {
                    resultArray[i] = firstArray[indexA];
                    indexA++;
                }
                else
                {
                    if (indexB < secondArray.Length)
                    {
                        resultArray[i] = secondArray[indexB];
                        indexB++;
                    }
                }


                Array.

                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine(resultArray[i]);
                }
                Console.ReadLine();
            }
        }
    }