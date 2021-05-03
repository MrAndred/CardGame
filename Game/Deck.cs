using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Deck
    {
        System.Collections.ArrayList deck;
        public Deck()
        {
            buildCards();
        }

        public Card get_Renamed(int index)
        {
            if (index < deck.Count)
            {
                return (Card)deck[index];
            }
            return null;
        }

        public void replace(int index, Card card)
        {
            deck[index] = card;
        }

        public int size()
        {
            return deck.Count;
        }

        public Card removeFromFront()
        {
            if (deck.Count > 0)
            {
                Object tempObject;
                tempObject = deck[0];
                deck.RemoveAt(0);
                Card card = (Card)tempObject;
                return card;
            }
            return null;
        }

        public void returnToBack(Card card)
        {
            deck.Add(card);
        }

        private void buildCards()
        {
            deck = new System.Collections.ArrayList();
            deck.Add(new Card(Card.CLUBS, Card.TWO));
            deck.Add(new Card(Card.CLUBS, Card.THREE));
            deck.Add(new Card(Card.CLUBS, Card.FOUR));
            deck.Add(new Card(Card.CLUBS, Card.FIVE));
            deck.Add(new Card(Card.CLUBS, Card.SIX));
            deck.Add(new Card(Card.CLUBS, Card.SEVEN));
            deck.Add(new Card(Card.CLUBS, Card.EIGHT));
            deck.Add(new Card(Card.CLUBS, Card.NINE));
            deck.Add(new Card(Card.CLUBS, Card.TEN));
            deck.Add(new Card(Card.CLUBS, Card.JACK));
            deck.Add(new Card(Card.CLUBS, Card.QUEEN));
            deck.Add(new Card(Card.CLUBS, Card.KING));
            deck.Add(new Card(Card.CLUBS, Card.ACE));

            deck.Add(new Card(Card.SPADES, Card.TWO));
            deck.Add(new Card(Card.SPADES, Card.THREE));
            deck.Add(new Card(Card.SPADES, Card.FOUR));
            deck.Add(new Card(Card.SPADES, Card.FIVE));
            deck.Add(new Card(Card.SPADES, Card.SIX));
            deck.Add(new Card(Card.SPADES, Card.SEVEN));
            deck.Add(new Card(Card.SPADES, Card.EIGHT));
            deck.Add(new Card(Card.SPADES, Card.NINE));
            deck.Add(new Card(Card.SPADES, Card.TEN));
            deck.Add(new Card(Card.SPADES, Card.JACK));
            deck.Add(new Card(Card.SPADES, Card.QUEEN));
            deck.Add(new Card(Card.SPADES, Card.KING));
            deck.Add(new Card(Card.SPADES, Card.ACE));

            deck.Add(new Card(Card.HEATRS, Card.TWO));
            deck.Add(new Card(Card.HEATRS, Card.THREE));
            deck.Add(new Card(Card.HEATRS, Card.FOUR));
            deck.Add(new Card(Card.HEATRS, Card.FIVE));
            deck.Add(new Card(Card.HEATRS, Card.SIX));
            deck.Add(new Card(Card.HEATRS, Card.SEVEN));
            deck.Add(new Card(Card.HEATRS, Card.EIGHT));
            deck.Add(new Card(Card.HEATRS, Card.NINE));
            deck.Add(new Card(Card.HEATRS, Card.TEN));
            deck.Add(new Card(Card.HEATRS, Card.JACK));
            deck.Add(new Card(Card.HEATRS, Card.QUEEN));
            deck.Add(new Card(Card.HEATRS, Card.KING));
            deck.Add(new Card(Card.HEATRS, Card.ACE));

            deck.Add(new Card(Card.DIAMONDS, Card.TWO));
            deck.Add(new Card(Card.DIAMONDS, Card.THREE));
            deck.Add(new Card(Card.DIAMONDS, Card.FOUR));
            deck.Add(new Card(Card.DIAMONDS, Card.FIVE));
            deck.Add(new Card(Card.DIAMONDS, Card.SIX));
            deck.Add(new Card(Card.DIAMONDS, Card.SEVEN));
            deck.Add(new Card(Card.DIAMONDS, Card.EIGHT));
            deck.Add(new Card(Card.DIAMONDS, Card.NINE));
            deck.Add(new Card(Card.DIAMONDS, Card.TEN));
            deck.Add(new Card(Card.DIAMONDS, Card.JACK));
            deck.Add(new Card(Card.DIAMONDS, Card.QUEEN));
            deck.Add(new Card(Card.DIAMONDS, Card.KING));
            deck.Add(new Card(Card.DIAMONDS, Card.ACE));
            }
    }
}
