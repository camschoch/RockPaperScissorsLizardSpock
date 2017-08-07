using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human : Players
    {
        public Human(string name, string hand)
        {
            this.name = name;
            this.hand = hand;
        }
        public string GetPlayerOneHand()
        {
            Console.WriteLine("Type Rock, Paper, Scissor, Lizard, Spock");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public string GetPlayerTwoHand()
        {
            Console.WriteLine("Type Rock, Paper, Scissor, Lizard, Spock");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
