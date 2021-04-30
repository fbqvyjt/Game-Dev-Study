using System;
using UsingDeckClass;

namespace CreateConstructor
{
    /// <summary>
    /// Classes and Objects Lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create and print a deck of cards
            Deck deck = new Deck();
            //deck.Print();

            // access and print Empty value
            // bool deckEmpty = deck.Empty;
            // Console.WriteLine("Deck Empty: " + deckEmpty);
            Console.WriteLine("Deck Empty: " + deck.Empty);

            // shuffle the deck
            // deck.Shuffle();
            // deck.Print(); prints the deck of cards no longer in order.
            Console.WriteLine();
            deck.Cut(26);
            deck.Print();

            // take top card
            Card card = deck.TakeTopCard();
            // next print the properties of the top card to tell us what iut is.
            Console.WriteLine();
            Console.WriteLine(card.Rank + " of" + card.Suit);

            Console.WriteLine(); 
        }
    }
}