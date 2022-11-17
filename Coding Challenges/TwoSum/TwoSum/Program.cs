using System;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your target");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] list = { 9, 11, 4, 8, 13, 1 };

            for (int i=0; i<list.Length; i++)
            {
                for (int j=i+1;j<list.Length;  j++)
                {
                    int placeholder = list[i] + list[j]; //remove line
                    if (placeholder == target)
                    {
                        Console.WriteLine("elements at positions " + i + " and " + j + " sum to make your target.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("No two numbers in this list sum to make your target: " + target);
                        Console.ReadLine();

                    }
                }
            }
        }
    }
}
