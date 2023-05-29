using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            //This makes Your Book
            Book1 book1 = new Book1("Doctor who and the towers of Askaban", "David Tennant", 800, "David", "Tennant", 1);
            // This gives Info about your book
            Console.WriteLine("The title of this book is " + book1.title + "and The author of this book is " + book1.author + ". \n\n\nThe amount of pages in this Book is " + book1.pages + ".\n\n");
            Console.WriteLine("This book marks " + book1.isBook() + " For the Is this a Book Test \n\n");

            Book1 book2 = new Book1("Doctor who and the leaning towers of Askaban", "Matt Smith", 1800, "Matt", "Smith", 2);
            Console.WriteLine("This book marks " + book2.isBook() + " For the Is this a Book Test \n\n");
            Console.WriteLine("The title of this book is " + book2.title + "and The author of this book is " + book2.author + ". \n\n\nThe amount of pages in this Book is " + book2.pages + ".\n\n");


            //This counts the book and should be the last command
            Console.WriteLine("There are " + Book1.bookCount + " Book's.\n\n");

            try
            {
                // This decides what you want to sort By
                int number;
                int Horse = 2;
                int House = 5;
                while (Horse != House)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("What would you like to filter by?\n\n\ntitle(1), firstName(2), lastName(3) pageCount(4), bookNumber(5), author(6):\n\n\n");
                number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        //Sorts this by a Title           
                        string[] Title = new string[Book1.bookCount];
                        //Check the order than add one
                        Title[0] = book1.title;
                        Title[1] = book2.title;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(Title[0] + "\n\n\n" + Title[1] + "\n\n\n");
                    }
                    else if (number == 2)
                    {
                        //Sorts this by a First Name           
                        string[] FirstName = new string[Book1.bookCount];
                        //Check the order than add one
                        FirstName[0] = book1.firstName;
                        FirstName[1] = book2.firstName;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(FirstName[0] + "\n\n\n" + FirstName[1] + "\n\n\n");
                    }
                    else if (number == 3)
                    {
                        //Sorts this by a Last Name        
                        string[] LastName = new string[Book1.bookCount];
                        //Check the order than add one
                        LastName[0] = book1.lastName;
                        LastName[1] = book2.lastName;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(LastName[0] + "\n\n\n" + LastName[1] + "\n\n\n");
                    }
                    else if (number == 4)
                    {
                        //Sorts this by the Page Amount       
                        int[] PageAmount = new int[Book1.bookCount];
                        //Check the order than add one
                        PageAmount[0] = book1.pages;
                        PageAmount[1] = book2.pages;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(PageAmount[0] + "\n\n\n" + PageAmount[1] + "\n\n\n");
                    }
                    else if (number == 5)
                    {
                        //Sorts this by a "Library" Number           
                        int[] BookNum = new int[Book1.bookCount];
                        //Check the order than add one
                        BookNum[0] = book1.bookNumber;
                        BookNum[1] = book2.bookNumber;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(BookNum[0] + "\n\n\n" + BookNum[1] + "\n\n\n");
                    }
                    else if (number == 6)
                    {
                        //Sorts this by a Author           
                        string[] Author = new string[Book1.bookCount];
                        //Check the order than add one
                        Author[0] = book1.author;
                        Author[1] = book2.author;
                        Console.WriteLine("Your books in order!\n\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(Author[0] + "\n\n\n" + Author[1] + "\n\n\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid please Try again\n\n\n");
                    }

                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error\n\n\n");
            }
        
            Console.ReadLine();
        }
    

    }
}
