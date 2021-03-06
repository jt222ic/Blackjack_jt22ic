﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame : model.rules.IgameObserver
    {
        
        private model.Game a_game;
        private view.IView a_view;



        public PlayGame(model.Game A_game,
            view.IView A_view)
        {
               a_game = A_game;
              a_view = A_view;
              a_game.addSub(this);
        }
        
        public bool Play()  //hidden dependencies
        {
           
            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            view.Options input = a_view.GetInput();

            if (input == view.Options.Play)
            {
                a_game.NewGame();
            }
            else if (input == view.Options.Hit)
            {
                a_game.Hit();
            }
            else if (input == view.Options.Stand)
            {
                a_game.stand();
            }

            return input != view.Options.Quit;
        }

        public void TimeDraw()
        {
           
            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
            System.Threading.Thread.Sleep(650);
        }
    }
}
