using System;
using System.Text;

namespace Star_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightUpper, heightLower, space, star;
            int count = 0;
            bool first = true, second = false;
            Console.WriteLine("How big is the diamond/2 :");
            heightUpper = Convert.ToInt32(Console.ReadLine());

            while (count <= heightUpper)
            {

                StringBuilder row = new StringBuilder();
                //print the spaces
                if (first)
                {
                    for (space = 0; space < (heightUpper - count); space++)
                    {
                        row.Append(" ");
                    }

                    //print the stars
                    for (star = 0; star < (2 * count) - 1; star++)
                    {
                        row.Append("*");

                    }

                    //output
                    count++;
                    Console.WriteLine(row);
                }
            }
            Console.ReadLine();
        }
    }
}
