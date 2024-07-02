using System;

namespace CountWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"The number of words in the sentence is: {wordCount}");
        }
    }
}