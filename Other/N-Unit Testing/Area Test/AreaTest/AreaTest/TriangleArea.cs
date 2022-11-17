using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTest
{
    class Triangle

        //herons formula
    {
        double s1, s2, s3;
        public double TriArea(double s1,double s2, double s3)
            //Using Heron's formula
        {
            double sp = 0.5 * (s1 + s2 + s3); //calculates the semi perimeter
            double SquaredArea = sp*(sp - s1)*(sp - s2)*(sp - s3);
            double area = Math.Sqrt(SquaredArea);
            return Math.Round(area, 2);
        }
        public double TriPerim(double s1, double s2, double s3)

        // here we assume that the length of each side is known
        {
            return s1+s2+s3;

        }

        
    }
}
