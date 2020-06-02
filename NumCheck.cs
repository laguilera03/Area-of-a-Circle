using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_a_Circle.Area_of_a_Circle
{
    class NumCheck
    {
        public static double CheckIfNum(string input)
        {
            double value;
            while (!double.TryParse(input, out value))
            {
                Console.WriteLine("Please input a number");
                input = Console.ReadLine();
            }
            return value;
        }
    }
}