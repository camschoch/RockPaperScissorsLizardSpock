using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class AI : Player
    {
        public AI(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        //public void randomHandSelect()
        //{
        //    Random random = new Random();
        //    int randomNumber = random.Next(0, 5);
        //    string[] selectionArray = { "Rock", "Paper", "Scissors", "Lizaed", "Spock"};

        //    hand = selectionArray[randomNumber];
        //}
    }
}
