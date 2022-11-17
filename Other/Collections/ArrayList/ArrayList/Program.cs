using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();
            for (int i=0; i<10; i++)
            {
                int num = r.Next(0, 100);
                Numbers.Add(num);
                Console.Write(num + " ");
            }
            //foreach (var number in Numbers)

            Console.WriteLine("The average of random numbers is {0}", Numbers.Average());
            Numbers.Insert(0, 10);
            //var index = Numbers.IndexOf(2);
            //Console.WriteLine("The index of position 0 is {0}", index);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Collections using List of Objects");
            var student = new List<Person>
            {
                new Person(){FirstName="Chloe",LastName="Cheng",age=24}

            };
            foreach (var n in student)
            {
                Console.Write("the person " + n.FirstName);
                Console.Write(" " + n.LastName);
                Console.Write(" has an age of " + n.age);
            }

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }
}
