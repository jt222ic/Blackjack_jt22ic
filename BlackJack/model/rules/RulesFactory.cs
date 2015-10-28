using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
        public IHitStrategy Soft17()
        {
            return new Soft17();
        }

        public IPlayerLooseWhenDraw playerLose()
        {
            return new PlayerLose();
        }

        
    }
}
