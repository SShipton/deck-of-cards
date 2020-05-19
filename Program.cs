using System;
using System.Collections.Generic;
using System.Linq;

namespace deck_of_cards
{
    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

    }
    class Program
    {
        private List<Card> Cards = new List<Card>();
        public void MakeCards()
        {

            var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            var faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var face in faces)
                {
                    var newCard = new Card()
                    {
                        Suit = suit,
                        Face = face,
                    };

                    Cards.Add(newCard);
                }
            }

            var rNG = new Random();

            for (var index = Cards.Count - 1; index >= 1; index--)
            {
                var otherIndex = rNG.Next(index);

                var firstCard = Cards[index];
                var otherCard = Cards[otherIndex];

                Cards[index] = otherCard;
                Cards[otherIndex] = firstCard;
            }
        }
    }
}



