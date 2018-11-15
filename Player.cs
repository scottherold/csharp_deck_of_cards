using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Player
    {
        private string name;

        // Just like in the Deck class, you will need to use a list for the 
        // player's hand. Setup the list here!

        private List<Card> hand;

        // Standard reference for Name creation using Encapsulation following 
        // the notes/lecture.

        public string Name
        {
            get
            {
                return name;
            }
        }

        // As with the Deck class you need to have a methdo that generates the 
        // object form the class. Player does this by giving the player a name
        // using the aforementioned name field/property and generates a 
        // new list of Card objects.

        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }
        
        // For drawing a card, you were on the right track, but below using
        // a reference to the Deck object as an argument. currentDeck is
        // a Deck object and using the Deal method to 'draw' a card, then
        // that card is added to the Player object's hand list. Deal() 
        // automatically removes the card from the Deck object.
        
        public Card Draw(Deck currentDeck)
        {
            Card drawCard = currentDeck.Deal();
            hand.Add(drawCard);
            return drawCard;
        }

        public Card Discard(int index)
        {
            Card discardCard;
            if (index < hand.Count)
            {
                discardCard = hand[index];
                hand.Remove(discardCard);
                return discardCard;
            }
            else
            {
                return null;
            }
        }

        // Added this little tester to the Player to make sure the player's
        // hand is working properly.

        public void ShowDeck()
        {
            foreach (Card deckCard in hand)
            {
                deckCard.SayCard();
            }
            Console.WriteLine(hand.Count);
        }
    }
}