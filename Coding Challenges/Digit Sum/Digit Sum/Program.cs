using System;
using System.Linq;

namespace Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int total = 0;

            //**Converts to ascii, means letters can return a sum
            //Could try using mod(10) - n%10, n = the entered number

            int[] numberArray = number.Select(o => Convert.ToInt32(o) - 48).ToArray();

            foreach (int n in numberArray)
            {
                total = total + n;            
            
            }
            Console.WriteLine("The sum of digits is: " + total);
            Console.ReadLine();
            
        }
    }
}
