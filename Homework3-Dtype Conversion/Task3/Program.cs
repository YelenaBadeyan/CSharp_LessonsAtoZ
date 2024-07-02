using System;

namespace ConvertClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string numericString = "12345";

            int intValue = Convert.ToInt32(numericString);

            Console.WriteLine("The first string is: " + numericString);
            Console.WriteLine("The converted integer is: " + intValue);
        }
    }
}