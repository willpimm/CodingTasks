using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class and create an object calc
            Calculator1 calc = new Calculator1();
            int x = 3;
            int y = 5;
            int sum = 0;
            int sub = 0;
            int mult = 0;
            int div = 0;

            sum = calc.Add(x, y);
            sub = calc.Sub(x, y);
            mult = calc.Mult(x, y);
            div = calc.Div(x, y);

            Console.WriteLine("{0} + {1}, {2}", x, y, sum);
            Console.WriteLine("{0} - {1} is, {2}", x, y, sub);
            Console.WriteLine("{0} * {1} is, {2}", x, y, mult);
            Console.WriteLine("{0} / {1} is, {2}", x, y, div);
            Console.ReadLine();

        }
    }
}
