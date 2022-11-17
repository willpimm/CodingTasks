using System;
using System.Text;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pick a random word
            string[] WordChoices = {"space","dinner","amazon","laptop"};
            var random = new Random();
            string RandWord = WordChoices[random.Next(0, WordChoices.Length)];
            int count = 0;
            
            // Convert to character list
            List<char> secretWordChars = new List<char>();
            secretWordChars.AddRange(RandWord.ToCharArray());
            
            StringBuilder displayWord = new StringBuilder();
            
            foreach (char n in secretWordChars)
            {
                displayWord.Append(new char[] { '*' });
            }
            Console.WriteLine(displayWord);

            while ((count<=7) && (displayWord.ToString() != RandWord))
            { 
                Console.WriteLine("Enter your character");
                char guess = Console.ReadLine()[0];

                for (int i = 0; i < secretWordChars.Count; i++)
                {
                    if (guess == secretWordChars[i])
                    {
                        displayWord.Replace('*', guess, i, 1);
                    }
                }
                Console.WriteLine(displayWord);
                count++;                                      
                                                  
            }
            if (count <= 7)
            {
                Console.WriteLine("You Won");
            }
            else
            {
                Console.WriteLine("You lost");
            }
        }

    }
}
