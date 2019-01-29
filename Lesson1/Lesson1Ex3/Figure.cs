using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Ex3
{
    class Figure
    {
        public Figure(Point p1, Point p2, Point p3)
        {
            Point = new Point[3];
            Point[0] = p1;
            Point[1] = p2;
            Point[2] = p3;
            Type = "Triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            Point = new Point[4];
            Point[0] = p1;
            Point[1] = p2;
            Point[2] = p3;
            Point[3] = p4;
            Type = "Quadrangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            Point = new Point[5];
            Point[0] = p1;
            Point[1] = p2;
            Point[2] = p3;
            Point[3] = p4;
            Point[4] = p5;
            Type = "Pentagon";
        }

        public string Type { get; set; }
        internal Point[] Point { get; set; }

        double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < Point.Length - 1; i++)
            {
                sum += LengthSide(Point[i], Point[i + 1]);
            }
            sum += LengthSide(Point[0], Point[Point.Length - 1]);
            Console.Write(sum);
        }
    }
}
