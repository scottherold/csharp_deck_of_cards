using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck
    {
        // You can create lists as fields.
        private List<Card> cards = new List<Card>();

        // The reason you need both a public and private field for the same list
        // is so that your List can be accessed by your program. Without using
        // a get property to return the private list above, you will not be
        // able to access the 'deck of cards' from Program.cs.

        public List<Card> Cards
        {
            get
            {
                return this.cards;
            }
        }

        // This is the default method for the Deck class. Without this, you cannot
        // generate a new deck when the Deck is initialized. Rather than starting
        // with a standard 'Generate' method, it works to simply create a Reset
        // method that generates your deck here.

        public Deck()
        {
            Reset();
        }

        // This is a method that both generates and resets your Deck. It references
        // your Card class to create a list of Card objects that creates the Deck
        // object class.

        public List<Card> Reset()
        {
            cards.Clear();
            foreach (string suitType in Card.Suits)
            {
                int i = 1;
                while (i < 14)
                {
                    cards.Add(new Card(suitType, i));
                    i++;
                }
            }
            return cards;
        }

        
        // Since this method returns a Card object, you must designate the 
        // 'type' as Card.
        
        public Card Deal()
        {
            Card dealCard = cards[0];
            cards.Remove(dealCard);
            return dealCard;
        }
        
        // Recycled code from your puzzle assignment.

        public void Shuffle()
        {
            Random rand = new Random();
            // int counter = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                Card shuffledCard = cards[i];
                int randIndex = rand.Next(0,cards.Count);
                cards[i] = cards[randIndex];
                cards[randIndex] = shuffledCard;
                // counter += 1;
            }
            // Console.WriteLine(counter);
        }
        
        // This is from the solution. It calls the method from the Card class
        // that iterates through the Deck cards list, and prints the values
        // from the Card class. Using this to QA my code -- thanks Devon!
        
        public void ShowDeck()
        {
            foreach (Card deckCard in cards)
            {
                deckCard.SayCard();
            }
            Console.WriteLine(cards.Count);
        }
    }
}