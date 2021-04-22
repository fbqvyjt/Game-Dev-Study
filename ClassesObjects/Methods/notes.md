# ***Methods on Behavior***
Here we learn how to access multiple behaviors of the deck object by calling the methods. 
<br></br>

1. ***Methods*** → allow us to access the behavior of the object
- When we want an object to take some action, we call a method (Called "functions" in other languages; "Method" is the term in C#)
- Methods take the form of → `Method()`
- In this instance, we will be using four different methods in the Deck Class → Print, Cut, Shuffle, and TakeTopCard
    - We don't need the deck itself to return anything in the Print, Cut and Shuffle methods, so their data type is `void`. TakeTopCard on the other hand, uses the `Card` data type.
- Note: (Parameters) vs. { Arguments; }

### ***Deck.Print Method***:
<p> Prints the contents of the deck. </p>
<pre><code> public void Print()
</code></pre>

### ***Deck.Shuffle Method***:
<p> Shuffles the deck </p>
<pre><code> public void Shuffle()
</code></pre>

### ***Deck.Cut Method***:
<p> Used to cut the deck of cards at a given point </p> 
<pre><code> public void Cut(
        int Location
)
</code></pre>

### ***Deck.TakeTopCard Method***:
<p> Selects the first card in the deck. </p>
<pre><code> public Card takeTopCard();
</code></pre>

- Different from the other methods, this one returns a `Card` Object.
    - You do not need to add anything in the parameters as you are just taking the top card.
- To see how these methods being used in code, see [here](MethodPrac.cs).
<br></br>

## Exercise 8: Rolling the Dice
Task: Create 2 dice, Tell the dice to roll themselves, print the top sides of the die and print their sum.
- See [here](Exercises8-9/Exercise8.cs) for code.

## Exercise 9: Look at the Cards
Task: Create a deck and tell it to print itself, tell the deck to shuffle and print itself, and take two cards from the deck and print their ranks and suits.
- See [here](Exercises8-9/Exercise9.cs) for code.