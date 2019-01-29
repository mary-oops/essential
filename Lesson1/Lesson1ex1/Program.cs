using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            double side1 = Convert.ToDouble(input1);
            double side2 = Convert.ToDouble(input2);
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimetr);
            Console.ReadKey();
        }
    }
}
