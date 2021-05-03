using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card[] myHand = new Card[5];
            deck.Shuffle();

            myHand[0] = deck.TakeTopCard();
            myHand[0].FlipOver();
            myHand[0].Print();

            myHand[1] = deck.TakeTopCard();
            myHand[1].FlipOver();
            myHand[1].Print();
            myHand[0].Print();
            
            Console.WriteLine();

        }
    }
}
