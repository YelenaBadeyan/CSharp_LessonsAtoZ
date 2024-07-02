using System;

namespace CastingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            double doubleValue = 20.5;
            float floatValue = 30.5f;
            char charValue = 'A';
            string stringValue = "123";

            double castedDoubleFromInt = intValue;
            Console.WriteLine("Casted int to double: " + castedDoubleFromInt);

            int castedIntFromDouble = (int)doubleValue;
            Console.WriteLine("Casted double to int: " + castedIntFromDouble);

            double castedDoubleFromFloat = floatValue;
            Console.WriteLine("Casted float to double: " + castedDoubleFromFloat);

            float castedFloatFromDouble = (float)doubleValue;
            Console.WriteLine("Casted double to float: " + castedFloatFromDouble);

            int castedIntFromChar = charValue;
            Console.WriteLine("Casted char to int: " + castedIntFromChar);

            int parsedIntFromString = int.Parse(stringValue);
            Console.WriteLine("Parsed string to int: " + parsedIntFromString);

            string convertedStringFromInt = intValue.ToString();
            Console.WriteLine("Converted int to string: " + convertedStringFromInt);

            byte castedByteFromInt = (byte)intValue;
            Console.WriteLine("Casted int to byte: " + castedByteFromInt);

            byte byteValue = 255;
            int castedIntFromByte = byteValue;
            Console.WriteLine("Casted byte to int: " + castedIntFromByte);
        }
    }
}