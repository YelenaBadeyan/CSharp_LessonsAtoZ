using System;
using System.IO;
using System.Reflection;

namespace WorkingWithFiles_UsingFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating the file
            string customPath = @"C:\Users\Yelena.Badeyan\Downloads\Person3.txt";
            FileInfo newFile = new FileInfo(customPath);

            //Writing into the file using StreamWriter

            Person person1 = new Person("Ashot", 25);

            string[] personInfo = { $"Name: {person1.Name}", $"Age: {person1.Age}" };
            using (StreamWriter writer = newFile.CreateText())
            {
                writer.WriteLine(personInfo);
            }

            //Reading from the file

            using (StreamReader file = newFile.OpenText())
            {
                string fileContent = file.ReadToEnd();
                Console.WriteLine(fileContent);
            }

            //Moving the file from one place to another


            string newPath = @"C:\Users\Yelena.Badeyan\Desktop\Files";

            newFile.MoveTo(newPath);




        }
    }


}


