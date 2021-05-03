using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class CardDriver
    {
        public static void Main(String[] args)
        {
            Deck deck = new Deck();
            Dealer dealer = new Dealer(deck);
            Console.WriteLine("\n Распечатка упорядоченной колоды карт");
            printDeck(deck);
            dealer.Shuffle();
            Console.WriteLine("\n Распечатка перетасованной колоды карт");
            printDeck(deck);
            Console.ReadLine();
        }

        public static void printDeck(Deck deck)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = deck.removeFromFront();
                    deck.returnToBack(card);
                    Console.Write(card.Dislplay() + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
