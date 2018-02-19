﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            this.cards = new Card[52];

            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    this.cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return this.cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
            }
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = random.Next(52);
                    if (assigned[destCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[destCard] = true;
                newDeck[destCard] = this.cards[i];
            }
            newDeck.CopyTo(this.cards, 0);
        }
    }
}
