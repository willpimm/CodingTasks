using System;

namespace PrimeNthPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            Console.WriteLine("enter a position: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The prime at this position is: " + primes[N-1]);
            Console.ReadLine();

            }
        }
    }

