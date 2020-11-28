using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySFGameWindow
{
    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            this.Initialize();
        }

        public void Initialize()
        {
            cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card() { suit = (Suit)i, face = (Face)j });

                    if (j <= 8)
                        cards[cards.Count - 1].Value = j + 1;
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
        }

        public void Shuffle()
        {
            /*
            Random rnd = new Random();
            int n = cards.Count;

            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
            */

            Random rnd = new Random();
            Card temp;

            for (int shuffleTime = 0; shuffleTime < 1000; shuffleTime++)
            {
                for (int i = 0; i < 52; i++)
                {
                    int secondCardIndex = rnd.Next(1, 13);
                    temp = cards[i];
                    cards[i] = cards[secondCardIndex];
                    cards[secondCardIndex] = temp;
                }
            }
        }

        public Card DrawACard()
        {
            if (cards.Count <= 0)
            {
                this.Initialize();
                this.Shuffle();
            }

            Card cardToReturn = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return cardToReturn;
        }

        public int GetAmountOfRemainingCrads()
        {
            return cards.Count;
        }

        public void PrintDeck()
        {
            int i = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine("Card {0}: {1} of {2}. Value: {3}", i, card.face, card.suit, card.Value);
                i++;
            }
        }
    }
}
