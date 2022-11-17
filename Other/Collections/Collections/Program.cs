using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Names = new List<String>();
            Names.Add("Will");
            Names.Add("Chloe");
            Names.Add("Josh");
            Names.Add("Joe");
            Names.Add("Tuya");

            foreach (var name in Names)
            {
                Console.WriteLine(name);

            }
            var Even = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var number in Even)
            {
                if (number%2 == 0)
                { 
                    Console.WriteLine("The number: " + number + " is even.");
                }
            }
            Console.ReadLine();
        }
    }
}
