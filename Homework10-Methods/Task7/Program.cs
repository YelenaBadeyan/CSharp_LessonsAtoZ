using System;

namespace SumAndProductExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum, product;

            GetSumAndProduct(num1, num2, out sum, out product);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }

        static void GetSumAndProduct(int num1, int num2, out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
        }
    }
}