using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class AI : Players
    {
        public AI(string name, string hand)
        {
            this.name = name;
            this.hand = hand;
        }
    }
}
