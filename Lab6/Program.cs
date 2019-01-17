using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.Write("Welcome to Justin's fancy casino!.\nWould you like to roll the dice? (Y/N) ");
            string roll = Console.ReadLine();
            int rCounter = 1;
            if (roll == "y")
            {
                do
                {   
                    Console.Write("How many sides does your dice have?\n (standard dice = 6 sides): ");

                    int numberOfSides = int.Parse(Console.ReadLine());
                    while (numberOfSides <= 0)
                    {
                        Console.Write("Please enter a number greater than 0: ");
                        numberOfSides = int.Parse(Console.ReadLine());
                    }
                    int firstRoll, secondRoll;

                    RDice(numberOfSides, out firstRoll, out secondRoll);
                    rCounter += 1;
                    Console.WriteLine("Roll {0}: {1}, {2}", rCounter, firstRoll, secondRoll);

                    Console.Write("Would you like to Roll again? ");
                    response = Console.ReadLine();

                } while (response == "y");
                Console.WriteLine("Thanks for playing. Goodbye!");
            }
            else
            {
                Console.WriteLine("Goodbye! Hope you play next time.");
            }
        }
        public static void RDice(int sides, out int rollOne, out int rollTwo)
        {   
            Random rando = new Random();
            rollOne = rando.Next(1, sides);
            rollTwo = rando.Next(1, sides);
        }
    }
}
