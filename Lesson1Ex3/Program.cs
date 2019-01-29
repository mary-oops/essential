using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 1, "A");
            Point b = new Point(0, 2, "B");
            Point c = new Point(0, 3, "C");
            Point d = new Point(0, 4, "D");
            Point e = new Point(0, 5, "E");

            Figure figure1 = new Figure(a, b, c);
            Figure figure2 = new Figure(a, b, c, d);
            Figure figure3 = new Figure(a, b, c, d, e);
            Console.Write("{0}, perimetr = ", figure1.Type);
            figure1.PerimeterCalculator();
            Console.Write("\n{0}, perimetr = ", figure2.Type);
            figure2.PerimeterCalculator();
            Console.Write("\n{0}, perimetr = ", figure3.Type);
            figure3.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
