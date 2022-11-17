using System;
using System.Text;

namespace Star_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, space, star;
            int count = 0;
            //bool first = true, second = false;
            Console.WriteLine("How big is the diamond:");
            height = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j <= height; j++)
            {
                StringBuilder rowUpper = new StringBuilder();
                for (space = 0; space < (height - count); space++)
                { rowUpper.Append(" "); }

                for (star = 0; star < (2 * count) - 1; star++)
                { rowUpper.Append("*"); }
                count++;
                Console.WriteLine(rowUpper);
            }
            count = height;
            for (int j = 0; j<= height-1; j++)
            {
                StringBuilder rowLower = new StringBuilder();
                for (space = 0; space <= (height - count); space++)
                { rowLower.Append(" "); }

                for (star = 1; star < (2 * count)-2; star++)
                { rowLower.Append("*"); }
                count--;
                Console.WriteLine(rowLower);

            }
            Console.ReadLine();
        }
    }
}
