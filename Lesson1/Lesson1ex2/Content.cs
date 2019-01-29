using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1ex2
{
    class Content
    {
        public Content(string paragraph)
        {
            this.Paragraph = paragraph;
        }

        public string Paragraph { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Paragraph);
        }
    }
}
