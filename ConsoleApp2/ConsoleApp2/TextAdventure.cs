using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TextAdventure
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
                Console.WriteLine("Thats " + Feeling + " To Hear");
                Console.Write("So what do you plan to be in the future? ");
                string Job;
                Job = Console.ReadLine();
                Console.WriteLine("So you want to be (a/an) " + Job + " When your Older");
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
                        Console.WriteLine("You awake in a strange place it seems to resemble a cabin.");
                        Console.WriteLine("However a figure emerges from the shadows.");
                        Console.WriteLine("He greets you with the following line 'Another challenger... it has been ages.' He says with some peculiar noises.");
                        Console.WriteLine("He than follows by saying 'Perhaps you have forgotten how this game is played.'");
                        bool Tutorial = false;
                        bool TutorialComplete = false;
                        Console.Write("Have you than? true/false");
                        Tutorial = Convert.ToBoolean(Console.ReadLine());
                        if (Tutorial == true)
                        {
                            Console.WriteLine("Good hope you remember well than.");
                            TutorialComplete = true;
                        }
                        else if (Tutorial == false)
                        {
                            Console.WriteLine("'Let me remind you' says the strange man");
                            TutorialComplete = false;
                        }
                        if (TutorialComplete == false)
                        {
                            Console.WriteLine("Suddenly a set of 4x2 slots appear in the table along with a deck of 1 card and a deck of 9 cards.");
                            Console.WriteLine("You suddenly notice 4 cards in your hand they are: a Squirrel, a stoat, a wolf, and a wolf");
                            Console.WriteLine("You also notice something peculiar about the stoat it seems to be sleeping?");
                            Console.WriteLine("A Squirrel is defined as a Free 0/1 Provides 1 blood to the card its sacrificed to.");
                            Console.WriteLine("A Stoat is defined as a 1 Blood 1/3 Provides 1 blood to the card its sacrificed to.");
                            Console.WriteLine("A Wolf is defined as a 2 Blood 3/2 Provides 1 blood to the card its sacrificed to.");
                            Console.WriteLine("Blood can be payed for by sacrificing your cards.");
                            Console.WriteLine("Understood? Press Enter to Proceed.");
                            Console.ReadLine();
                            Console.WriteLine("The strange man proceeds by demanding you to 'Play the Squirrel Card.'");
                            Console.Write("Where do you place it Slot 1[Unopposed] Slot 2[Unopposed] Slot 3[Unopposed] Slot 4[Unopposed] Enter(1, 2, 3, 4)");
                            int FirstSquirrelSlot = 0;
                            FirstSquirrelSlot = Convert.ToInt32(Console.ReadLine());
                            if (FirstSquirrelSlot == 1)
                            {
                                Console.WriteLine("Now Play Your Stoat.");
                                Console.Write("Stoats Cost 1 Blood, Sacrifices MUST BE MADE. Press Enter to Sacrifice the Meager Squirrel");
                                Console.WriteLine("Now Play The Stoat.");
                                Console.Write("Where do you place it Slot 1[Unopposed] Slot 2[Unopposed] Slot 3[Unopposed] Slot 4[Unopposed] Enter(1, 2, 3, 4)");
                                int StoatSlot = 0;
                                StoatSlot = Convert.ToInt32(Console.ReadLine());
                                if (StoatSlot == 1)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");
                                }
                                if (StoatSlot == 2)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 3)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 4)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                            }
                            if (FirstSquirrelSlot == 2)
                            {
                                Console.WriteLine("Now Play Your Stoat.");
                                Console.Write("Stoats Cost 1 Blood, Sacrifices MUST BE MADE. Press Enter to Sacrifice the Meager Squirrel");
                                Console.WriteLine("Now Play The Stoat.");
                                Console.Write("Where do you place it Slot 1[Unopposed] Slot 2[Unopposed] Slot 3[Unopposed] Slot 4[Unopposed] Enter(1, 2, 3, 4)");
                                int StoatSlot = 0;
                                StoatSlot = Convert.ToInt32(Console.ReadLine());
                                if (StoatSlot == 1)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");
                                }
                                if (StoatSlot == 2)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 3)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 4)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                            }
                            if (FirstSquirrelSlot == 3)
                            {
                                Console.WriteLine("Now Play Your Stoat.");
                                Console.Write("Stoats Cost 1 Blood, Sacrifices MUST BE MADE. Press Enter to Sacrifice the Meager Squirrel");
                                Console.WriteLine("Now Play The Stoat.");
                                Console.Write("Where do you place it Slot 1[Unopposed] Slot 2[Unopposed] Slot 3[Unopposed] Slot 4[Unopposed] Enter(1, 2, 3, 4)");
                                int StoatSlot = 0;
                                StoatSlot = Convert.ToInt32(Console.ReadLine());
                                if (StoatSlot == 1)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");
                                }
                                if (StoatSlot == 2)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 3)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 4)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                            }
                            if (FirstSquirrelSlot == 4)
                            {
                                Console.WriteLine("Now Play Your Stoat.");
                                Console.Write("Stoats Cost 1 Blood, Sacrifices MUST BE MADE. Press Enter to Sacrifice the Meager Squirrel");
                                Console.WriteLine("Now Play The Stoat.");
                                Console.Write("Where do you place it Slot 1[Unopposed] Slot 2[Unopposed] Slot 3[Unopposed] Slot 4[Unopposed] Enter(1, 2, 3, 4)");
                                int StoatSlot = 0;
                                StoatSlot = Convert.ToInt32(Console.ReadLine());
                                if (StoatSlot == 1)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");
                                }
                                if (StoatSlot == 2)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 3)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                                if (StoatSlot == 4)
                                {
                                    Console.WriteLine("Wolves Require 2 Sacrifices, You dont have enough.");
                                    Console.WriteLine("A bell falls from above");
                                    Console.Write("Ring the bell to end your turn and commence Combat. Press Enter to ring the bell.");
                                    Console.WriteLine("Your stoat stands Unopposed.");
                                    Console.WriteLine("The first number in card Definition (If it were to have no cost) is its power.");
                                    Console.WriteLine("As if it were magic the card jumped up and headbutted the unopposed slot.");
                                    Console.WriteLine("A scale suddenly falls from above.");
                                    Console.WriteLine("You dealt me 1 damage i added it to the scale.");
                                    Console.WriteLine("You win if you tip my side all the way down.");
                                    Console.WriteLine("The Man tips the scale all the way down towards him with a finger 'Like This'");
                                    Console.WriteLine("My Turn.");
                                    Console.WriteLine("Your Stoat stands in the way of my coyote.");
                                    Console.WriteLine("My Coyote dealt 2 damage to your Stoat.");
                                    Console.WriteLine("That means your Stoats health is 2 less.");
                                    Console.WriteLine("If a creature's health reaches 0 it dies.");
                                    Console.WriteLine("It's Your turn again.");
                                    Console.Write("You may draw from your deck or draw a squirrel.");

                                }
                            }
                        }
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
