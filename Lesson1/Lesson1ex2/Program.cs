using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            string title = Console.ReadLine();
            Book book = new Book(author, content, title);

            book.ShowAuthor();
            book.ShowContent();
            book.ShowTitle();
            Console.ReadKey();

        }
    }
}
