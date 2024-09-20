using System;
using System.IO;

class Person : IDisposable
{
    public string Name { get; set; }
    public int Age { get; set; }
    private StreamWriter _writer;
    private string _filePath;
    private bool _disposed = false;

    public Person(string name, int age, string filePath)
    {
        Name = name;
        Age = age;
        _filePath = filePath;
        try
        {
            _writer = new StreamWriter(_filePath, true);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error: Access to the file is denied. {ex.Message}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Error: Directory not found. {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Unable to open the file. {ex.Message}");
        }
    }

    public void SaveToFile()
    {
        try
        {
            if (_writer != null)
            {
                string personInfo = $"Name: {Name}, Age: {Age}";
                _writer.WriteLine(personInfo);
                Console.WriteLine($"Person saved: {personInfo}");
            }
        }
        catch (ObjectDisposedException ex)
        {
            Console.WriteLine($"Error: Attempted to write to a closed file. {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: Writing to file failed. {ex.Message}");
        }
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            if (_writer != null)
            {
                _writer.Dispose();
                Console.WriteLine("File stream closed.");
            }
            _disposed = true;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Custom path for the file
        string customPath = @"C:\Users\Yelena.Badeyan\Downloads\Person.txt";

        try
        {
            using (Person person1 = new Person("Mery", 30, customPath))
            {
                person1.SaveToFile();
            }

            using (Person person2 = new Person("Jane", 25, customPath))
            {
                person2.SaveToFile();
            }

            Console.WriteLine("All persons' information saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error occurred: {ex.Message}");
        }

        // Second part: reading from the file
        Console.WriteLine("Reading from the file");

        try
        {
            using (var file = File.OpenText(customPath))
            {
                var fileContent = file.ReadToEnd();
                Console.WriteLine(fileContent);
            }
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
    }
}
