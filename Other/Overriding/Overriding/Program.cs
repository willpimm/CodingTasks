    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        { 

        AreaOfShapes areaSquare = new AreaOfShapes();
        double a = 3.0;
        double b = 4.0;
        double area = 0.0;
        area = areaSquare.Square(a, b);
        Console.WriteLine("area of square : {0}", area);
            Console.ReadLine();
        }
    }
    
}
