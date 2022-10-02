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
            try
            {
                string options;
                Console.Write("Enter What You Want to do (Squareroot or Basic(+,-,*,/)): ");
                options = Console.ReadLine();
                if (options == "Basic")
                {
                    string dont = "Dont";
                    string chess = "chess";
                    while (chess != dont)
                    {
                        try
                        {
                            string done = "done";
                            if (done != chess)
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
                                }
                                else if (operation == "-")
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
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Operation");
                                }
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Error");
                        }
                    }
                } else if (options == "Squareroot")
                {
                    try
                    {
                        string done = "true";
                        string chess = "chess";
                        if (done != chess)
                        {
                            Console.Write("Enter a Number: ");
                            double num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(Math.Sqrt(num1));

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                }
            }

            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
}
}