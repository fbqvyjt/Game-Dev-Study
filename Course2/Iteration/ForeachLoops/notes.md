# ***Foreach? Ha! More like Halo Reach?***
How to use `foreach` loops and how they differ from `for` loops

## The Foreach Loop
- The `foreach` loop is an alternative way to iterate over an array or list.
    - With some exceptions, by C# Programming Convention we should always default to using foreach loops over for
- To demonstrate how to use `foreach` loops, use the code from the `for` loop section and make changes there.

## How to Use Foreach Loops!

<details>
<summary> Code to follow along </summary>

```C#
using System;
using System.Collections.Generic;
// create a using directive for your new DLL here.
using ConsoleCards;

namespace ForeachLoops
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
            // FIRST FOREACH REPLACEMENT 
            foreach (Card card in hand)
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
            foreach (Card card in hand)
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
<br></br>

1. The first loop we can change to a `foreach` loop is the first print statment after we've added a few cards to the list.

2. The way we handle `foreach` loops is to have its parameters declare the data type of the elements of the list we are iterating over, and declare a name each of the elements that are processed each time in the loop, `in` the list we've created

3. Inside the foreach loop, there is only one change that needs to take place: replace the list's element with the name we just declared
    - the output is initially hand[0], then cycles as many times as the number of elements in the list

```C#
foreach (Card card in hand)
{
    Console.WriteLine(card.Rank + " of " +
        card.Suit);
}
```
4. The place you can't replace the `for` to the `foreach` is when we add 5 cards to the hand.
    - This is because we must use a `for` loop when we are not iterating over an array or list.

5. What if we want to remove the card that has been picked?
    - Simple, right? Well, if you were to write `hand.Remove(card);`, you would get an error. This is because you cannot modify the Collections directory.
    - If we want to make changes, we HAVE to use a for loop. We are never allowed to change the list inside a `foreach` loop.

<br></br>

## Important Things to remember
1. If we were trying to find the location of a particular value we'd need to keep track of that location, and ther's no way ina `foreach` loop to know where we are in the array or list on a particular iteration.

2. We can't use a `foreach` loop to change contents in an array or list.

