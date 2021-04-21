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
            deck.Print();
        }
    }
}