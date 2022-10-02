using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book1
    {
        public string title;
        public string author;
        public int pages;

        public Book1(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book with title of " + aTitle + "\n");

            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
