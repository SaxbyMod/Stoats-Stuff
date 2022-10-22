using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Have you had a good day today (Say how you feel not yes/no) as in [Good/Bad]? ");
                string Feeling;
                Feeling = Console.ReadLine();
                Console.WriteLine("Ah so you have had an " + Feeling + " Day ");
                Console.Write("So what did you do today? ");
                Console.ReadLine();
                Console.WriteLine("Thats Good To Hear");
                Console.Write("So what do you plan to be in the future? ");
                string Job;
                Job = Console.ReadLine();
                Console.WriteLine("So you want to " + Job + " When your Older");
                Console.Write("So is that all? [True/False] ");
                bool isThatAll;
                isThatAll = Convert.ToBoolean(Console.ReadLine());
                if (isThatAll == false)
                {
                    Console.Write("So what do you want to play [Inscryption/Pony Island/The Hex]? ");
                    string Game;
                    Game = Console.ReadLine();
                    if (Game == "Inscryption")
                    {
                        Console.WriteLine("Coming Soon!");
                        Console.ReadLine();
                    }
                    else if (Game == "Pony Island")
                    {
                        Console.WriteLine("Coming Soon!");
                        Console.ReadLine();
                    }
                    else if (Game == "The Hex")
                    {
                        Console.WriteLine("Coming Soon!");
                        Console.ReadLine();
                    }
                } else
                {
                    Console.WriteLine("Goodbye!");
                }
            } catch
            {
                Console.WriteLine("Error Occured");
            }
        }
    }
}
