using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "parts","traps","arts","rats","starts","tarts","rat","art","tar","tars","stars","stray"};
            string StarSort = string.Concat("star".OrderBy(c => c));

            foreach (string n in words)
            {
                string sorted = string.Concat(n.OrderBy(c => c));

                if (sorted == StarSort)
                {
                    Console.WriteLine(n + " is an anagram of star");
                } 
            }
            Console.ReadLine();
        }
    }
}
