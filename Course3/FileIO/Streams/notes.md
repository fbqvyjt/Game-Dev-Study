# ***Streams***
What are streams and how are they used?

## Importance of File IO
- Data flows into and/or out of our programs on ***Streams***
- The big idea is that we can use files to persist data that lives beyond a single execution of our game.
- So, we can store that data in one game play session and retrieve it in another game play session, or we can even store that data when we design our game and then retrieve it as we play our game. 

## What are Streams? How are they used?
- Conceptually, streams are the way that data flows into and out of our programs.
    1. ***Standard Input Stream***
        - The standard input stream is where the `Console.ReadLine()` method reads from...
            - You guessed it, it's the ***keyboard*** 
    2. ***Standard Output Stream***
        - The standard output steam is where the `Console.WriteLine()` method writes to...
            -  Wow! You got this! It's the ***console***, or the ***Command Prompt Window***
- The important takeaway from this chapter as a whole is that we can replace both the input and output streams with files instead of the keyboard and the console.