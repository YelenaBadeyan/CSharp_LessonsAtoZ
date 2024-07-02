using System;

namespace SwitchStatementWithStringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "start";

            switch (command.ToLower())
            {
                case "start":
                    Console.WriteLine("The system is starting.");
                    break;
                case "stop":
                    Console.WriteLine("The system is stopping.");
                    break;
                case "pause":
                    Console.WriteLine("The system is pausing.");
                    break;
                case "resume":
                    Console.WriteLine("The system is resuming.");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
