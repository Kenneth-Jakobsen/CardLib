using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            for(int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            throw new System.NotImplementedException();
        }

        public void Shuffle()
        {
            throw new System.NotImplementedException();
        }
    }
}