using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in RangeGenerator.Generate(5, 10))
            {

                Console.WriteLine($"A {i}");
            }
        }
    }

    public static class RangeGenerator
    {
        public static IEnumerable<int> Generate(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine($"B {i}");
                yield return i + 100;
            }
        }
    }
}