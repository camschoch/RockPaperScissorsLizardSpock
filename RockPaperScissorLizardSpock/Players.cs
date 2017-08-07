using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public abstract class Players
    {
        Random random = new Random();
        public string name;
        public string hand;
        public Players()
        { 
            
        }
    }
}
