using System;

namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user information
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your profession: ");
            string profession = Console.ReadLine();

            Console.WriteLine("\nUser Information:");
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, Profession: {profession}");
        }
    }
}