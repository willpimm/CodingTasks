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
            bool go = true;
            int GuessCount = 0;
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine("the random number is " + number);

            while ((go == true) && (GuessCount < 5))
            {

                Console.WriteLine("Enter an integer between 1 and 100");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    Console.ReadLine();
                    GuessCount++;
                }

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    Console.ReadLine();
                    GuessCount++;
                }

                if (guess == number)
                {
                    Console.WriteLine("That is the correct number");
                    Console.ReadLine();
                    go = false;
                }
            }
                Console.WriteLine("Unlucky, you lost");
                Console.ReadLine();


              
      
        }
    }
}