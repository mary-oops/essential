using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1ex2
{
    class Book
    {
        public Book(string author, string content, string title)
        {
            this.Author = new Author(author);
            this.Content = new Content(content);
            this.Title = new Title(title);
        }

        public Author Author { get; set; }
        public Content Content { get; set; }
        public Title Title { get; set; }

        public void ShowAuthor()
        {
            Author.Show();
        }
        public void ShowContent()
        {
            Content.Show();
        }
        public void ShowTitle()
        {
            Title.Show();
        }
    }
}
