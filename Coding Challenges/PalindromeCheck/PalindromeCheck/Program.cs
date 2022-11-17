using System;
using System.Linq;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word for Palindrome check!");
            string palindrome = Console.ReadLine();

            //remove whitespace

            string palindromeStr = String.Concat(palindrome.Where(c => !Char.IsWhiteSpace(c)));
            char[] palindromeCharArray = palindromeStr.ToCharArray();

            char[] flipped = palindromeStr.ToCharArray();
            Array.Reverse(flipped);

            if (palindromeCharArray.SequenceEqual(flipped))
            {
                Console.WriteLine("The word is a palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
                Console.ReadLine();
            }

        }
    }
}
