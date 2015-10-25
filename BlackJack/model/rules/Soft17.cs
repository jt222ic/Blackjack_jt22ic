using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17 : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            int[] cardScore = a_dealer.getCardArrayValues();
            int total = 0;

            if (a_dealer.CalcScore() == g_hitLimit)
            {
                foreach (Card card in a_dealer.GetHand())
                {
                    if (card.GetValue() != Card.Value.Ace)
                    {
                      total += cardScore[(int)card.GetValue()];
                    }
                }
                return total <= 6;
            }

            return a_dealer.CalcScore() < g_hitLimit;
        }


    }
}
