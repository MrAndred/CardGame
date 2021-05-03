using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Dealer
    {
        private Deck deck;
        public Dealer(Deck d)
        {
            deck = d;
        }

        public void Shuffle()
        {
            int num_cards = deck.size();
            for (int i = 0; i < num_cards; i++)
            {
                int index = (int)(SupportClass.Random.NextDouble() * num_cards);
                Card card_i = (Card)deck.get_Renamed(i);
                Card card_index = (Card)deck.get_Renamed(index);
                deck.replace(i, card_index);
                deck.replace(index, card_index);
            }
        }

        public Card dealCard()
        {
            if (deck.size()>0)
            {
                return deck.removeFromFront();
            }

            return null;
        }

        public class SupportClass
        {
            static public System.Random Random = new System.Random();
        }
    }
}
