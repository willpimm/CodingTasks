using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessCount = 0;
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine("the random number is " + number);

            while (GuessCount < 5)
            {

                Console.WriteLine("Enter an integer between 1 and 100");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    GuessCount++;
                }

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    GuessCount++;
                }

                if (guess == number)
                {
                    Console.WriteLine("That is the correct number");
                    break;
                }
            }
                Console.WriteLine("Unlucky, you lost");


              
      
        }
    }
}