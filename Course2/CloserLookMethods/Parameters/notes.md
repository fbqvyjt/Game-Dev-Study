# Parameters and How They Work
Discussion on how parameters actually work in practice.

## Well, What are they?
***Parameters*** → parameters are all about getting information from the code that's calling a method into that method so that it can do whatever it's supposed to do.

## How is this Used?
1. We're just going to take a couple of cards from the deck, and we're doing that so we can focus on how parameters work. 

<details>
<summary> This is what the TakeCard method looks like in its own class file</summary>

```C#
/// <summary>
        /// Takes the card at the given location from the deck. If the deck is empty
        /// or the location is invalid based on the size of the deck, returns null
        /// </summary>
        /// <returns>the card at the given location</returns>
        public Card TakeCard(int location)
        {
            // demonstration output
            Console.WriteLine("Inside the method, the parameter is " +
                location);

            if (Empty ||
                location < 0 ||
                location > cards.Count - 1)
            {
                return null;
            }
            else
            {
                Card card = cards[location];
                cards.RemoveAt(location);
                return card;
            }
        }

```


</details>

2. One of the great things about methods as reusable code is we can pass in different arguments on the calling side and the behavior of the method will depend upon that particular argument once we get inside the method because the parameter has a different value. 

<details>
<summary> This is what the main file looks like</summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /// <summary>
    /// A Closer Look at Methods code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates various methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            // method with no return value, no parameters
            //deck.Shuffle();

            // method with return value, no parameters
            //Card topCard = deck.TakeTopCard();
            //topCard.FlipOver();
            //topCard.Print();

            // method with no return value, with parameters
            //deck.Cut(deck.Count / 2);

            // method with return value, with parameters
            Card card = deck.TakeCard(deck.Count - 1);
            card.FlipOver();
            card.Print();
            card = deck.TakeCard(0);
            card.FlipOver();
            card.Print();

            Console.WriteLine();
        }
    }
}

```
</details>

3. We can think of a parameter as a local variable that gets that value when the method is called. And then within the body of the method,
we just treat that parameter like a local variable. 