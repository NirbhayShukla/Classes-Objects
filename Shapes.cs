using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Shapes
    {
        static double Area(int side)
        {
            return side * side;
        }

        static double Area(int l, int b)
        {
            return l * b;
        }

        static double Area(double radius)
        {
            return 3.14*radius*radius;
        }

        static double Area(double l,double b)
        {
            return .5 * l * b;
        }
    }
}
