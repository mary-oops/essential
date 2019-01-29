using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1ex2
{
    class Author
    {
        public Author(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
        }
    }
}
