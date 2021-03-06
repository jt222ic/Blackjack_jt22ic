﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : IView
    {

        private const char PLAY_KEY = 'p';
        private const char HIT_KEY = 'h';       // inspired kk222hk
        private const char STAND_KEY = 's';
        private const char QUIT_KEY = 'q';

        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.WriteLine("Type '{0}' to Play, '{1}' to Hit, '{2}' to Stand or '{3}' to Quit\n", PLAY_KEY, HIT_KEY,STAND_KEY,QUIT_KEY);
          
        }

        public Options GetInput()
        {
            switch (System.Console.In.Read())
            {
                case PLAY_KEY:
                    return Options.Play;
                case HIT_KEY:
                    return Options.Hit;
                case STAND_KEY:
                    return Options.Stand;
                case QUIT_KEY:
                    return Options.Quit;
                default:
                    return Options.Default;
                
            }                                   // skapar switch satsen för constat char värde
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }
            
        }
    }
}
