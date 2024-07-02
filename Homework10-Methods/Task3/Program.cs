using System;

namespace ModifyArrayWithRef;

class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = { 1, 2, 3, 4 };
        ModifyArrayWithRef(ref inputArray);
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.WriteLine(inputArray[i]);
        }

    }

    public static void ModifyArrayWithRef(ref int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = (int)Math.Pow(inputArray[i], 2);
        }
    }
}