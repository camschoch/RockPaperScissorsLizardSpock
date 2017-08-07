using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human : Player
    {
        public Human(string name, string hand, int score)
        {
            this.name = name;
            this.hand = hand;
            this.score = score;
        }
        //public string GetPlayerHand()
        //{
        //    Console.WriteLine("Type Rock, Paper, Scissors, Lizard, Spock");
        //    string userInput = Console.ReadLine();
        //    return userInput;
        //}
    }
}
