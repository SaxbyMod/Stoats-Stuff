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
            string chess = "Chess";
            string death = "death";
            while (chess != death)
            {
                try
                {
                    string check = "Nothing";
                    string calculator = "Calculator";
                    while (check != calculator)
                    {
                        Console.Write("Enter a Number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter an Operation: ");
                        string operation = Console.ReadLine();
                        Console.Write("Enter a Number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        if (operation == "+")
                        {
                            Console.WriteLine(num1 + num2);
                        } else if (operation == "-")
                        {
                            Console.WriteLine(num1 - num2);
                        }
                        else if (operation == "*")
                        {
                            Console.WriteLine(num1 * num2);
                        }
                        else if (operation == "/")
                        {
                            Console.WriteLine(num1 / num2);
                        } else
                        {
                            Console.WriteLine("Invalid Operation");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            } }
    }
}
