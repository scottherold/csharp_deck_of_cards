using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            Player newPlayer = new Player("Scott");
            // Console.WriteLine(newPlayer.Name);
            // newDeck.ShowDeck();
            newDeck.Shuffle();
            newDeck.ShowDeck();
            Console.WriteLine("******");
            newPlayer.Draw(newDeck);
            newPlayer.ShowDeck();
            Console.WriteLine("******");
            newDeck.ShowDeck();
            Console.WriteLine("******");
            newPlayer.Discard(0);
            newPlayer.ShowDeck();
        }
    }
}
