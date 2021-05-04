# ***For Loops, or Not For Loops***
That is the question. Whether 'tis nobler to understand, or not, how iterations work is the importance in this section.

## Determining What Kind of Iteration (or Looping):

-  When we know how many times we'll need to iterate when we get to a loop during execution of our program, we should use: 
    - `for` loop
    and/or
    - `foreach` loop (we will focus on ONLY for loops in this section)

## Let's Visualize How to Use For Loops!

<details>
<summary> Code to follow along </summary>

```C#
using System;
using System.Collections.Generic;
// create a using directive for your new DLL here.
using ConsoleCards;

namespace ForLoops
{
    /// <summary>
    /// For Loops Lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates for Loops
        /// </summary>
        /// <param name ="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // add a few cards to the list
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());

            // print cards in the hand

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine(hand[i].Rank + " of" +)
                    hand[i].Suit;
            }

            // add 5 cards to hand
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

             // print cards in the hand
            Console.WriteLine();
            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine(hand[i].Rank + " of" +)
                    hand[i].Suit;
            }

            Console.WriteLine();
        }
    }
}

```
</details>

1. Make sure to add the System Collections using directive.

2. Now lets make a new deck of cards object.

3. Create a list that represents the hand of cards that you pick from that deck.

4. Next, Add cards from the top of the deck to your hand (You can pick as many as you want).

5. Now we are going to make use of our for loop! 
    - To print the cards in your hand, create a `for` loop that has a ***loop control variable***, `i`.
    - Initialize it as an `int` to zero. and continue looping as long as `i` is less than than however many cards in the hand.
        - The reason for less than, is that as we are counting from 0, as we index into the hand, we are going to need to use indicies of 0, 1, and 2.
        - ***NOTE***: We don't have to always start our loop control variable at 0 and we don't have to always use < in our condition.
    - Lastly in your `for` loop, continue the loop and increment `i` once every time ()
    - You loop should look like:
        - for (initialization; condition; modifier){}
        - `for (int i = 0; i < hand.Count; i++){}`

6. Inside the `for` loop, have the terminal print the card's rank (or number) " of " the card's suit.

7. Add more cards using a For loop and then print them again!