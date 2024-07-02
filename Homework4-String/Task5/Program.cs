using System;

namespace StringSplittingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruitList = "apple,banana,orange";
            string languagesList = "C#, Java, JavaScript, Python";

            string[] fruits = fruitList.Split(',');

            Console.WriteLine("Fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit.Trim());
            }

            string[] languages = languagesList.Split(',');

            Console.WriteLine("\nProgramming Languages:");
            foreach (string language in languages)
            {
                Console.WriteLine(language.Trim());
            }
        }
    }
}
