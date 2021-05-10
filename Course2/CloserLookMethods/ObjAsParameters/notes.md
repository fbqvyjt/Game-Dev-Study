# ***Passing Objects as Parameters***
What happens when we pass a reference type, an object, rather than a value type, into a method. 

## What's the Big Idea?
1. The example for this lecture is cheating at cards. In the newly created `CardChanger()` class, we expose a method called, Change Card.
2. You pass in a card object when you call this method, and it changes the state of that card object to be an ace.
3. The biggest take away from this is say you are cheating... *GASP*! and you want to provide a brand new card to replace the one that you have to complete that royal flush or 4 of a kind you so desire. 
    - For each of the cards in our hand, we call that change card method
    - We print the results of cheating by flipping over each card in the hand, and printing out that card.
    - The important idea is that, once we have an object passed in method, we can manipulate the state of that object, and it will be changed throughout the code.
    - Because, we have taken the data that is that the memory address for the card object and we've actually changed the data there, when we execute this line.
    - So, this method doesn't have to return anything. It's actually changing the object that was passed in, in this particular case by changing it to be an ace.
    - Over in the main method, after we have called Change Card with a particular card object, that card object is now an ace. And it is persistently an ace throughout the rest of our code here, because we actually changed the value that object's location in memory.


