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
                string humanName = "";
                string humanPlayerHand = "";
                int score = 0;
                playerOne = new Human(humanName, humanPlayerHand, score);
                playerOne.getPlayerName();


                string computerName = "";
                playerTwo = new AI(computerName, score);
                playerTwo.getPlayerName();

                Console.WriteLine("\nPlayer one is " + playerOne.name + "\nPlayer two is " + playerTwo.name);
                Console.ReadLine();
                playGame();
            }


            else if (numberOfPlayers == "2")
            {
                string oneName = "";
                string playerHand = "";
                int score = 0;
                playerOne = new Human(oneName, playerHand, score);
                playerOne.getPlayerName();
                Console.WriteLine("\nNow we set up player two.");
                string twoName = "";
                playerTwo = new Human(twoName, playerHand, score);
                playerTwo.getPlayerName();

                Console.WriteLine("Player one is " + playerOne.name + "\nPlayer two is " + playerTwo.name);
                Console.ReadLine();

                playGame();
                
            }

            else
            {
                Console.WriteLine("\nSorry we did not understand lets retry.");
                setNumberOfPlayers();
            }
        }
        private void playGame()
        {
            Console.WriteLine(playerOne.name + " has won " + playerOne.score + " and " + playerTwo.name + " has won " + playerTwo.score + "\n" + "Now we wil begin the round.");

            if (numberOfPlayers == "1")
            {
                playerOne.GetPlayerHand();

                playerTwo.GetPlayerHand();

                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();
            }


            else if (numberOfPlayers == "2")
            {
                Console.WriteLine(playerOne.name + " pick your hand.");
                playerOne.GetPlayerHand();

                Console.WriteLine(playerTwo.name + " pick your hand.");
                playerTwo.GetPlayerHand();

                Console.WriteLine(playerOne.name + " has " + playerOne.hand + "\n" + playerTwo.name + " has " + playerTwo.hand + "\n");
                compareHands(playerOne.hand, playerTwo.hand);
                Console.ReadLine();

            }
        }
        private void equalHands(string randomOne, string randomTwo)
        {
                Console.WriteLine("It's a tie");
                Console.ReadLine();
        }
        private void playerOneRock(string randomOne, string randomTwo)
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
        private void randomOnePaper(string randomOne, string randomTwo)
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
        private void randomOneScissors(string randomOne, string randomTwo)
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
        private void randomOneSpock(string randomOne, string randomTwo)
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
        private void randomOneLizard(string randomOne, string randomTwo)
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

        private void compareHands(string randomOne, string randomTwo)
        {
            if (randomOne == randomTwo)
            {
                equalHands(randomOne, randomTwo);
            }
            else if (randomOne == "Rock")
            {
                playerOneRock(randomOne, randomTwo);
            }
            else if (randomOne == "Paper")
            {
                randomOnePaper(randomOne, randomTwo);
            }
            else if (randomOne == "Scissors")
            {
                randomOneScissors(randomOne, randomTwo);
            }
            else if (randomOne == "Spock")
            {
                randomOneSpock(randomOne, randomTwo);
            }
            else if (randomOne == "Lizard")
            {
                randomOneLizard(randomOne, randomTwo);
            }
            if (playerOne.score >= 2)
            {
                Console.WriteLine(playerOne.name + " Wins the game!\n");
                restartGame();
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine(playerTwo.name + " Wins the game!\n");
                restartGame();
            }
            else
            {
                playGame();
            }
        }
        private void restartGame()
        {
            Console.WriteLine("Would you like to play again? Type yes or no.");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                setNumberOfPlayers();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Thank you for playing!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nSorry we didn't understatnd please type yes or no.");
                restartGame();
            }
        }
    }
}
