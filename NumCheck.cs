using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_a_Circle.Area_of_a_Circle
{
    class NumCheck
    {
        public static double CheckIfNum(string input)
        {
            while (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Please input a number");
                input = Console.ReadLine();

                if (double.TryParse(input, out double resultTwo))
                {
                    break;
                }
            }

            return double.Parse(input);
        }
    }
}