using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // get upper and lower bounds
            Console.Write("Enter a lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.Write("Enter an upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            // print numbers in range
            for (int i = lowerBound; i <= upperBound; i++)
            {
                Console.WriteLine(i);
            }

            // game objects and shuffle
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            deck.Shuffle();

            // deal 5 cards into the hand
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // flip all the cards over
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            // print the hand
            foreach (Card card in hand)
            {
                card.Print();
            }

            Console.WriteLine();
        }
    }
}