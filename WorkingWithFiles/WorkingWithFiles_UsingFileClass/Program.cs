﻿using System;
using System.IO;

class Program
{
    static void Main(string[] args)

    {

        try
        {
            using (FileStream fs = File.Create(@"C:\Users\Yelena.Badeyan\Downloads\Person1.txt"))
            {
            }

            string customPath = @"C:\Users\Yelena.Badeyan\Downloads\Person1.txt";
            Person person1 = new Person("Elen", 25);

            string[] personInfo = { $"Name: {person1.Name}", $"Age: {person1.Age}" };
            File.WriteAllLines(customPath, personInfo);

            Console.WriteLine("Person information saved successfully.");

            //Reading from the file 
            string content = File.ReadAllText(customPath);
            Console.WriteLine(content);

            //Checking if the file exists or not
            bool ifExists = File.Exists(customPath);
            Console.WriteLine($"Does the file exists: {ifExists}");

            //Some date functions
            DateTime creationTime = File.GetCreationTime(customPath);
            DateTime lastAccessTime = File.GetLastAccessTime(customPath);
            DateTime lastModificationDate = File.GetLastWriteTime(customPath);

            Console.WriteLine($"File creation date is {creationTime}, " +
                $"last access date iss {lastAccessTime} " +
                $"and the last write time is {lastModificationDate}.");
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: File not found. {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Unable to read from file. {ex.Message}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error: Access to the file is denied. {ex.Message}");
        }
        finally
        {
            Console.WriteLine("The End of the first step");
        }



    }
}
