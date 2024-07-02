using System;

namespace SwapCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = 'A';
            char secondChar = 'B';

            var result = SwapCharactersWithRef(ref firstChar, ref secondChar);
            if (result)
            {
                Console.WriteLine(firstChar);
                Console.WriteLine(secondChar);
            }
        }

        public static bool SwapCharactersWithRef(ref char ch1, ref char ch2)
        {
            if (ch1 == ch2 || ch1 == null || ch2 == null)
            {
                return false;
            }

            char temp = ch1;
            ch1 = ch2;
            ch2 = temp;
            return true;
        }
    }
}
