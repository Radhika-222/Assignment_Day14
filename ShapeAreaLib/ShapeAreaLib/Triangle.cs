using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Triangle
    {
        public double Area(double @base, double height)
        {
            double area = 0.5* @base * height;
            return area;
        }
    }
}
