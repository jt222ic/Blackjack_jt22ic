using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{

    public enum Options
    {
        Play,
        Hit,
        Stand,
        Quit,
        Default

    }

    interface IView
    {


        void DisplayWelcomeMessage();
                    //int Getinput ->Options GetInput
       Options GetInput();
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
    }


    

}

