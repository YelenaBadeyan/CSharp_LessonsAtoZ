using System;

namespace SwitchWithFallThroughExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 2;

            switch (level)
            {
                case 1:
                    Console.WriteLine("Level 1: Beginner");
                    break;
                case 2:
                    Console.WriteLine("Level 2: Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Level 3: Advanced");
                    break;
                default:
                    Console.WriteLine("Invalid level");
                    break;
            }
        }
    }
}
