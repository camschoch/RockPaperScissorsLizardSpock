using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class GameBoard
    {

        public void setNumberOfPlayers()
        {
            Console.WriteLine("How many players would you like to have. (type 1 or 2)\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    string Name = getPlayerOneName();
                    string playerHand = "";
                    Human playerName = new Human(Name, playerHand);
                    playerName.hand = playerName.GetPlayerOneHand();




                    break;
                case "2":
                    string oneName = getPlayerOneName();
                    string playerOneHand = "";
                    Human playerOneName = new Human(oneName, playerOneHand);
                    playerOneName.hand = playerOneName.GetPlayerOneHand();

                    string twoName = getPlayerTwoName();
                    string playerTwoHand = "";
                    Human playerTwoName = new Human(twoName, playerTwoHand);
                    playerTwoName.hand = playerTwoName.GetPlayerOneHand();
                    break;
            }
        }
        public string getPlayerOneName()
        {
            Console.WriteLine("Please enter your name.\n");
            string playerOnename = Console.ReadLine();
            return playerOnename;
        }
        public string getPlayerTwoName()
        {
            Console.WriteLine("Please enter your name.\n");
            string playerTwoname = Console.ReadLine();
            return playerTwoname;
        }
        //public string GetPlayerOneHand()
        //{
        //    Console.WriteLine("Type Rock, Paper, Scissor, Lizard, Spock");
        //    string userInput = Console.ReadLine();
        //    return userInput;
        //}
        //public string GetPlayerTwoHand()
        //{
        //    Console.WriteLine("Type Rock, Paper, Scissor, Lizard, Spock");
        //    string userInput = Console.ReadLine();
        //    return userInput;
        //}
    }
}
