using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary
{
    public class Card
    {
        public Card(Suit newSuit, Rank newRank)
        {
            this.rank = newRank;
            this.suit = newSuit;
        }

        // 默认构造函数私有化
        private Card() { }

        public readonly Suit suit;
        public readonly Rank rank;

        public override string ToString()
        {
            return "The " + this.rank + " of " + this.suit + "s";
        }
    }
}
