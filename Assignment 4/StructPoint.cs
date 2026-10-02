using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class StructPoint
    {
        public void RunExample6()
        {
            // prompt the user to enter the coordinates of the first point
            Console.WriteLine("Enter the X1 coordinate:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y1 coordinate:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Point p1 = new Point(x1, y1 );


            // prompt the user to enter the coordinates of the second point
            Console.WriteLine("Enter the X2 coordinate:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y2 coordinate:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Point p2 = new Point(x2, y2);
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");  

            
        }
    }
}
public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

}