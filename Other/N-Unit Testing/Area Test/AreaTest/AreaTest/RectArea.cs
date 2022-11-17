using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTest
{
    public class Rectangle
    {

        public double RArea(double height, double width)
        {
            return height * width;

        }
        public double RPerim(double height, double width)
        {
            return 2 * (height + width);
        }

    }
}
