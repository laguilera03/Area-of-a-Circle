using System;

namespace Area_of_a_Circle.Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();


            //double pi = 3.14;
            Console.WriteLine("Enter a radius: ");
            string userInput = Console.ReadLine();
            circle.radius = NumCheck.CheckIfNum(userInput);
            circle.GetArea();
            circle.GetCircum();

            //double A = pi * r * r;
            Console.WriteLine("The circumference of a circle of radius {0} is: {1}", circle.radius, circle.c);

            ////Diameter
            //double D = 2 * r;
            //Console.WriteLine("The diameter of a circle of radius {0} is: {1}", , D);

            ////How many miles per Gallon
            //Console.WriteLine("Enter miles per gallon: ");
            //userInput = Console.ReadLine();
            //double milesPerGallon = double.Parse(userInput);
            //double gallonsUsed = C / milesPerGallon;
            //Console.WriteLine("{0} miles per gallon in a circumference {1} uses: {2}", milesPerGallon, C, gallonsUsed);
        }
    }
}