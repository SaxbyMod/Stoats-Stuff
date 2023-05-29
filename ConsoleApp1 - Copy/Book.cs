using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book1
    {
        // This is The Book Object
        public string title;
        public string author;
        public int pages;
        public string firstName;
        public string lastName;
        public static int bookCount = 0;
        public int bookNumber;

        public Book1(string aTitle, string aAuthor, int aPages, string aFirstName, string aLastName, int aBookNumber)
        {
            Console.WriteLine("Creating Book with title of " + aTitle + "\n\n");

            title = aTitle;
            author = aAuthor;
            pages = aPages;
            firstName = aFirstName;
            lastName = aLastName;
            bookNumber = aBookNumber;
            bookCount++;
        }

        public bool isBook()
        {
            if (pages >= 32)
            {
                return true;
            }
            return false;
        }
    }
}
