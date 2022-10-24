using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence

{
    class Program
    {
        static void Main()
        {
            string salesStr = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";
            string[] sales = salesStr.Split(',');

            int count = 0;
            int max = 0;

            foreach (string n in sales)
            {

                if (Int16.Parse(n) == 0)
                {
                    count++;
                    if (count > max)
                        max = count;

                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine("The maximum number of days without a sale is " + max);
            Console.ReadLine();



        }


    }
}

