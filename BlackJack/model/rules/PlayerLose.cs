using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerLose : IPlayerLooseWhenDraw
    {

        public bool PlayerLoose(Player a_player)
        {
            return true;
         
        }

    }
}
