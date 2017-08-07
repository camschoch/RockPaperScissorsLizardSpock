using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Player
    {
        Random random = new Random();
        public string name;
        public string hand;
        public int score;
        public Player()
        { 
            
        }
        public virtual void GetPlayerHand()
        {
            Console.WriteLine("Type 1, 2, 3, 4, or 5\n 1 = Rock\n 2 = Paper\n 3 = Scissors\n 4 = Lizard\n 5 = Spock");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    hand = "Rock";
                    break;
                case "2":
                    hand = "Paper";
                    break;
                case "3":
                    hand = "Scissors";
                    break;
                case "4":
                    hand = "Lizard";
                    break;
                case "5":
                    hand = "Spock";
                    break;
                default:
                    Console.WriteLine("That didn't work please try again.");
                    Console.ReadLine();
                    GetPlayerHand();
                    break;
            }
        }
        public virtual void getPlayerName()
        {
            Console.WriteLine("Please enter your name.\n");
            name = Console.ReadLine();
        }
    }
}
