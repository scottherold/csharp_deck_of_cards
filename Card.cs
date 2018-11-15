using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Card
    {
        // You must use fields for your properties to access and hold data.

        private string stringVal;
        private string suit;
        private int val;
        public static string[] Suits = new string[4] {"Clubs","Diamonds","Hearts","Spades"};
        
        // You can use methods that take in arguments!! 
        // In this example, the method is going to take in two arguments that
        // will define the the above fields. There will be another method in 
        // Deck class that will feed the 'suitType' and 'cardVal'
        // parameters to this method.

        public Card(string suitType, int cardVal)
        {
            if (cardVal == 1)
            {
                stringVal = "Ace";
            }
            else if (cardVal == 11)
            {
                stringVal = "Jack";
            }
            else if (cardVal == 12)
            {
                stringVal = "Queen";
            }
            else if (cardVal == 13)
            {
                stringVal = "King";
            }
            else
            {
                stringVal = cardVal.ToString();
            }
            suit = suitType;
            val = cardVal;
        }

        // This is used with the ShowCard() method in the Deck Class. It shows the 
        // value and suit of each card in the Deck's cards list.

        public void SayCard()
        {
            System.Console.WriteLine("The {0} of {1}", stringVal, suit);
        }
    }
}