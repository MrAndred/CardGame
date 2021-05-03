using System;

namespace Game
{
    public class Card
    {
        private int suit;
        private int rank;
        private bool face_up;


        public const int DIAMONDS = 4; //Бубны
        public const int HEATRS = 3; //Черви
        public const int SPADES = 6; //Пики
        public const int CLUBS = 5; //Черви

        public const int TWO = 2;
        public const int THREE = 3;
        public const int FOUR = 4;
        public const int FIVE = 5;
        public const int SIX = 6;
        public const int SEVEN = 7;
        public const int EIGHT = 8;
        public const int NINE = 9;
        public const int TEN = 10;
        public const int JACK = 74;
        public const int QUEEN = 81;
        public const int KING = 75;
        public const int ACE = 65;

        public Card(int suit, int rank) //Создание новой карты
        {
            this.suit = suit;
            this.rank = rank;
        }

        public int Suit
        {
            get
            {
                return suit;
            }
        }
        public int Rank { get; }
        public bool FaceUp { get; }
        public void faceUp() { face_up = true; }
        public void faceDown() { face_up = false; }
        public string Dislplay()
        {
            string display;
            if (rank > 10)
            {
                display = Convert.ToString((char)rank);
            }
            else
            {
                display = Convert.ToString(rank);
            }

            switch (suit)
            {
                case DIAMONDS:
                    return display + Convert.ToString((char)DIAMONDS);
                case HEATRS:
                    return display + Convert.ToString((char)HEATRS);
                case SPADES:
                    return display + Convert.ToString((char)SPADES);
                default:
                    return display + Convert.ToString((char)CLUBS);
            }
        }
    }
}
