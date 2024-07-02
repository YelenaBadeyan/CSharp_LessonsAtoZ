using System;

namespace GetHashCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            int hash1 = str1.GetHashCode();
            int hash2 = str2.GetHashCode();
            int hash3 = str3.GetHashCode();

            Console.WriteLine($"Hash code of str1 ('{str1}'): {hash1}");
            Console.WriteLine($"Hash code of str2 ('{str2}'): {hash2}");
            Console.WriteLine($"Hash code of str3 ('{str3}'): {hash3}");

            Console.WriteLine($"\nstr1 and str2 have the same content: {str1 == str2}");
            Console.WriteLine($"str1 and str2 have the same hash code: {hash1 == hash2}");
            Console.WriteLine($"str1 and str3 have different content: {str1 != str3}");
            Console.WriteLine($"str1 and str3 have different hash codes: {hash1 != hash3}");
        }
    }
}
