using System;
using System.Collections.Generic;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word: ");

            string word = Console.ReadLine();
            char[] split = word.ToCharArray();
            
            Array.Reverse(split);
            Console.WriteLine(split);
            Console.ReadLine();
        }
    }
}
