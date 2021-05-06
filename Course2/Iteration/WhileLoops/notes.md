# ***Loops? You While-ing!***
What are While loops and how are they different from `for` and `foreach` loops.

## Let's Define and Practice While Loops!
- ***`while` Loops*** → give us a way to iterate or loop when we don't know how many times we're going to need to loop.
- Lets make code so that we can prompt for and get a level from a user 1-100. Well fine and done, but it's a little messy since we can just make code that allows us to do that but also we can surpase the integer range that it may be looking for.

- See Completed Coded [Here](WhileLoopsLecture.cs)

1. We input validation under the prompt.
    - Now remember, the parameters of the while loop are a boolean expression that evaluates to `true` or `false`
    - It's great to use a while loop because we can keep looping until the player provides valid input.
    - So what constitute invalid input for their while level? 
        - Well, there are actually two ranges of numbers that are invalid.
        - Anything less than one, and anything greater than 110. ↓
2. So we'll say that while level is less than one,or level is greater than 110.
    - If either one of those is true, because that's how or works, is one or both of them is true means that the total Boolean expression is true.
    - It's impossible to have both, right? You can't think of a number that's both less than one and greater than 110.
        - But if this Boolean expression evaluates to false, it means that level is in fact between 1 and 110 inclusive.  

3. If they've provided invalid input, we shoudl print an error message and reprompt.

<br></br>

## Some Important Notes on While Loops
- With while loops, it's possible for us to end up in something called an ***infinite loop***.
    - An infinite loop, loops far more many times than you had intended when you wrote that particular loop.
    - If our Boolean expression evaluated to true, sending us into the loop body, that Boolean expresssion will still be true the next time we evaluate it
    -  An Acronym used to avoid infinite loops is: 
    - ***ITM*** → Initialize, Test, and Modify
        - Not initializing level, so violating the `i` part of the acronym is sort of unreasonable in this scenario.
        - Test your program to make sure that an invalid input is working.
        - After you test your program out, make the necessary changes that need to make it work.

