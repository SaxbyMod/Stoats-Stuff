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
            Book1 book1 = new Book1("Doctor who and the towers of Askaban", "Myself", 800);

            Console.WriteLine("The title of this book is " + book1.title + "and The author of this book is " + book1.author + ". \n The amount of pages in this Book is " + book1.pages + ".\n");

            Book1 book2 = new Book1("Doctor who and the leaning towers of Askaban", "Myself", 1800);
            
            Console.WriteLine("The title of this book is " + book2.title + "and The author of this book is " + book2.author + ". \n The amount of pages in this Book is " + book2.pages + ".\n");

            Console.ReadLine();
        }
    }
}
