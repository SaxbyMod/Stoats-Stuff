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
            Book1 book1 = new Book1();
            book1.title = "Doctor who and the towers of Askaban";
            book1.author = "Myself";
            book1.pages = 800;

            Book1 book2 = new Book1();
            book2.title = "Doctor who and the leaning towers of Askaban";
            book2.author = "Myself";
            book2.pages = 1800;

            Console.WriteLine("The title of this book is " + book1.title + "and The author of this book is " + book1.author + ". \n The amount of pages in this Book is " + book1.pages + ".");
            Console.WriteLine("The title of this book is " + book2.title + "and The author of this book is " + book2.author + ". \n The amount of pages in this Book is " + book2.pages + ".");

            Console.ReadLine();
        }
    }
}
