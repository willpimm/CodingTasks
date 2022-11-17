using System;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessCount = 0;
            Random rand = new Random();
            int number = rand.Next(1, 100);
            Console.WriteLine("the random number is " + number);
            int guess = 101;

            while ((GuessCount < 5) && (guess!=number))
            {

                Console.WriteLine("Enter an integer between 1 and 100");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    GuessCount++;
                }

                else if(guess > number)
                {
                    Console.WriteLine("Lower");
                    GuessCount++;
                }

            }
            if (guess == number)
            {
                Console.WriteLine("Correct");
            }

            else 
            {
                Console.WriteLine("Unlucky, you lost");
            }
        }
    }
}
