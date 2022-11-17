using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTest
{
    class Circle
    {
        double pi = Math.PI;
        public double CircArea(double radius)
        {
            return pi * Math.Pow(radius, 2);
        }

        public double CircPerim(double radius)
        {
            return 2 * pi * radius;
        }
    }

    
}
