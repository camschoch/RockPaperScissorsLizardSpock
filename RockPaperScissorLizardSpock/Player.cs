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
        public string GetPlayerHand()
        {
            Console.WriteLine("Type Rock, Paper, Scissors, Lizard, Spock");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public void randomHandSelect()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            string[] selectionArray = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

            hand = selectionArray[randomNumber];
        }
    }
}
