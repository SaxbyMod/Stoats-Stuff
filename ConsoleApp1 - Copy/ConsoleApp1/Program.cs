using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //This makes Your Book
           Book1 book1 = new Book1("Doctor who and the towers of Askaban", "Myself", 800);
            // This gives Info about your book
            Console.WriteLine("The title of this book is " + book1.title + "and The author of this book is " + book1.author + ". \n The amount of pages in this Book is " + book1.pages + ".\n");
            Console.WriteLine("This book marks " + book1.isBook() + " For the Is this a Book Test \n");
            
            Book1 book2 = new Book1("Doctor who and the leaning towers of Askaban", "Myself", 1800);
            Console.WriteLine("This book marks " + book2.isBook() + " For the Is this a Book Test \n");
            Console.WriteLine("The title of this book is " + book2.title + "and The author of this book is " + book2.author + ". \n The amount of pages in this Book is " + book2.pages + ".\n");


            //This counts the book and should be the last command
            Console.WriteLine("There are " + Book1.bookCount + " Book's.");
            Console.ReadLine();
        }
    }
}
