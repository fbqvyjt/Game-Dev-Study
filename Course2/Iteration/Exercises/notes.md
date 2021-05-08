# ***Iterations Practice***
Practice examples for For, Foreach, and While Loops

<details>
<summary> Example 1: Keeping the Odd - For Loops </summary>

Tasks:
* Add a list variable to hold integers and create a list object for that variable.
* Use a for loop to populate the list with the integers from 1 to 10 (including 1 and 10).
* Use a for loop to print the contents of the list.

* Use a backward forloop, starting at the last index in the list, to remove the even numbers from the list.
* Use a for loop to print the contents of the list. 
    - Note: By ugly coincidence, this would also work with a forward for loop because the elements that "escape processing" would all be odd numbers.

* Populate a list with the numbers from 1 to 5 inclusive. Use a forward for loop (starting i at 0) to remove 1, 2, and 3 from the list.
* Print the list to see that 2 gets skipped over, staying in the list.

- See Solution Code [here](exercise3.cs)

</details>
<br></br>


<details>
<summary> Example 2: For and Foreach Loops </summary>

Tasks:
1. Print numbers in user selected range
    - Prompt for and get lower and upper bounds for numbers to print
    - Use a for loop to print the numbers between the lower and upper bound (inclusive).

2. Create objects
    - Inside the `Main()` method, declare a deck variable
    - Inside the `Main()` method, declare a list variable that will hold a hand of cards and create a new list object for that variable.
    - Tell the deck to shuffle itself.

3. Deal & print the cards in a hand using `for` and `foreach` loops
    - Use a `for` loop to deal 5 cards from the deck to the hand
    - Use a `for` loop to flip all the cards in the hand over. Do NOT hard-code 5 as the upper limit of the loop.
    - Use a `foreach` loop (not a for loop) to print all the cards in the hand (remember, the `Card` class exposes a `Print()` method).


- See Solution Code [here](exercise4.cs)

</details>
<br></br>


<details>
<summary> Example 3: While Loops </summary>

Tasks:
1. Create and use a menu using a while loop
    - Create a menu of choices for your user. It should look like the following:

```C#
**************

Menu:

1 - NewGame

2 - LoadGame

3 - Options

4 - Quit

****************
```
- You should then prompt for and read in the user's choice as an integer.
- Your application should print an appropriate response confirming their choice, such as: `Loading game...`
- If the user selects 4, you should stop the while loop and exit the application when the user presses enter.

2. Implement input validation
    - Add a while loop that validates the user's input value before printing the appropriate message or quits the game. Although you could include this validation in your if statement and your outer while loop, use a while loop for this to get more practice with while loops.

3. Refractor
    - Now that you've practiced using another while loop, delete the while loop from the previous problem and use your if statement and the outer while loop to implement the input validation.

- See Solution Code [Here](exercise5.cs)

</details>
<br></br>
