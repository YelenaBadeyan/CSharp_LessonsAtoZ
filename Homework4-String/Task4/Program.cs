using System;

namespace StringSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string blogText = "Armenia is a unitary, multi-party, democratic nation-state with an ancient cultural heritage. The Armenian Highlands has been home to the Hayasa-Azzi, Shupria and Nairi. By at least 600 BC, an archaic form of Proto-Armenian, an Indo-European language, had diffused into Armenian Highlands.";
            string word1 = "Armenia";
            string word2 = "unitary";
            string word3 = "democratic";

            int indexWord1 = blogText.IndexOf(word1, StringComparison.OrdinalIgnoreCase);
            int indexWord2 = blogText.IndexOf(word2, StringComparison.OrdinalIgnoreCase);
            int indexWord3 = blogText.IndexOf(word3, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Index of '{word1}': {indexWord1}");
            Console.WriteLine($"Index of '{word2}': {indexWord2}");
            Console.WriteLine($"Index of '{word3}': {indexWord3}");
        }
    }
}