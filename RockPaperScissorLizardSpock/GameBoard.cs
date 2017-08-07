using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class GameBoard
    {
        Player playerOne;
        Player playerTwo;
        Random random = new Random();
        public string numberOfPlayers;
        public GameBoard()
        {
        }
        public void setNumberOfPlayers()
        {
            Console.WriteLine("How many players would you like to have. (type 1 or 2)\n");
            numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                string humanName = getPlayerName();
                string humanPlayerHand = "";
                int score = 0;
                playerOne = new Human(humanName, humanPlayerHand, score);
                playerOne.hand = playerOne.GetPlayerHand();


                string computerName = randomNameSelect(random.Next(0, 3));
                playerTwo = new AI(computerName, score);
                playerTwo.randomHandSelect();


                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();
            }


            else if (numberOfPlayers == "2")
            {
                string oneName = getPlayerName();
                string playerHand = "";
                int score = 0;
                playerOne = new Human(oneName, playerHand, score);
                playerOne.hand = playerOne.GetPlayerHand();

                string twoName = getPlayerName();
                playerTwo = new Human(twoName, playerHand, score);
                playerTwo.hand = playerTwo.GetPlayerHand();

                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();
                
            }

            else
            {
                Console.WriteLine("sorry we did not understand lets retry.");
                Console.ReadLine();
                setNumberOfPlayers();
            }
        }
        public string getPlayerName()
        {
            Console.WriteLine("Please enter your name.\n");
            string playername = Console.ReadLine();
            return playername;
        }
        public string randomNameSelect(int randomNumber)
        {
            string[] selectionArray = { "James", "Sally", "Ken" };

            string randomName = selectionArray[randomNumber];
            return randomName;
        }

        public void playGame()
        {
            Console.WriteLine(playerOne.name + " has won " + playerOne.score + " and " + playerTwo.name + " has won " + playerTwo.score + "\n" + "Now we wil begin the next round.");

            if (numberOfPlayers == "1")
            {
                playerOne.hand = playerOne.GetPlayerHand();

                playerTwo.randomHandSelect();

                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();
            }


            else if (numberOfPlayers == "2")
            {
                Console.WriteLine(playerOne.name + " pick your hand.");
                playerOne.hand = playerOne.GetPlayerHand();

                Console.WriteLine(playerTwo.name + " pick your hand.");
                playerTwo.hand = playerTwo.GetPlayerHand();

                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();

            }
        }

        public void compareHands(string randomOne, string randomTwo)
        {
            if (randomOne == randomTwo)
            {
                Console.WriteLine("It's a tie");
                Console.ReadLine();

            }
            if (randomOne == "Rock")
            {
                if (randomOne == "Rock" && randomTwo == "Paper")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();
                }
                else if (randomOne == "Rock" && randomTwo == "Scissors")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Rock" && randomTwo == "Lizard")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Rock" && randomTwo == "Spock")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
            }
            if (randomOne == "Paper")
            {
                if (randomOne == "Paper" && randomTwo == "Rock")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Paper" && randomTwo == "Scissors")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Paper" && randomTwo == "Lizard")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Paper" && randomTwo == "Spock")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
            }
            if (randomOne == "Scissors")
            {
                if (randomOne == "Scissors" && randomTwo == "Rock")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Scissors" && randomTwo == "Paper")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Scissors" && randomTwo == "Lizard")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Scissors" && randomTwo == "Spock")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
            }
            if (randomOne == "Spock")
            {
                if (randomOne == "Spock" && randomTwo == "Rock")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Spock" && randomTwo == "Scissors")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Spock" && randomTwo == "Paper")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Spock" && randomTwo == "Lizard")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
            }
            if (randomOne == "Lizard")
            {
                if (randomOne == "Lizard" && randomTwo == "Rock")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Lizard" && randomTwo == "Paper")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Lizard" && randomTwo == "Scissors")
                {
                    Console.WriteLine(randomTwo + " Wins!");
                    playerTwo.score += 1;
                    Console.ReadLine();

                }
                else if (randomOne == "Lizard" && randomTwo == "Spock")
                {
                    Console.WriteLine(randomOne + " Wins!");
                    playerOne.score += 1;
                    Console.ReadLine();

                }
            }
            if (playerOne.score >= 2)
            {
                Console.WriteLine(playerOne.name + " Wins!");
                Console.ReadLine();
                return;
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine(playerOne.name + " Wins!");
                Console.ReadLine();
                return;
            }
            if (playerOne.score <= 2)
            {
                playGame();
            }
            else if (playerTwo.score <= 2)
            {
                playGame();
            }
        }
    }
}
