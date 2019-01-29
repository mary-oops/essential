using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Ex3
{
    class Point
    {
        public Point(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

    }
}
