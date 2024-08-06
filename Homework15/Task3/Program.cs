using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in FibonacciSequencecc.Generate(14))
            {
                Console.WriteLine(i);
            }

        }
    }

    public static class FibonacciSequencecc
    {
        public static IEnumerable<int> Generate(int len)
        {
            int a = 0, b = 1, c = 0;
            yield return a;
            yield return b;
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                yield return c;
                a = b;
                b = c;
            }

        }
    }
}