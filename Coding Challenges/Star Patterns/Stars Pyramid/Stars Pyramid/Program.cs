using System;
using System.Collections.Generic;

namespace Stars_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int count = 1;
            int space;
            int star;

            Console.WriteLine("Enter number of layers: ");
            height = Convert.ToInt32(Console.ReadLine());

            //produce a list with x spaces and y stars

            while (count <= height)
            {
                var row = new System.Text.StringBuilder();

                //print the spaces

                for (space = 0; space < (height-count); space++)
                {
                    row.Append(" ");

                }
                // print the stars

                for (star=0; (star < (2 * count) - 1);star++)
                {
                    row.Append("*");
                }
                count++;
                Console.WriteLine(row);
            }
            Console.ReadLine();

        }
    }
}
