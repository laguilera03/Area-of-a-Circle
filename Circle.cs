using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_a_Circle.Area_of_a_Circle
{
    class Circle
    {
        public double pi = 3.14;
        public double radius { get; set; }

        //public Circle()
        //{
        //
        //}

        public double area;
        public double c;

        public void GetArea()
        {
            area = pi * radius * radius;
        }

        public void GetCircum()
        {
            c = 2 * pi * radius;
        }
    }
}
