# Methods
Implementing the roll method to our die project.

## Tips on Implementing the Roll Method
1. We start with the access modifier
    - Just as with fields, if we don't put in access modifier, then our method will be by default, private. And the same applies to properties as well.

2. The next thing we provide for our method is a return type.
    - So sometimes a method will return something like our deck take top card method from the previous course would return a card object.
    - But sometimes a method doesn't return anything. And that's the case here, we're just going to roll the die, changing the internal state of the die without returning any information to whoever told us to roll.
    - So we're going to use a special keyword that means, I don't return anything. And that special keyword is `void`.

3. Now we put the method name, Roll().
    - We put open parenthesis, close parenthesis,and if in fact we had any parameters like we had for our Die constructor that took in the number of sides, then we would put those parameters here,but we don't have any for the roll method, so we just put open and close parentheses with nothing in between them. 
4. One really important note, the random class produces only PSEUDO random numbers and if we were to call the random class in the methods, the return would be the same, because each time the die is rolled, the seed is the same and thus nothing will change on each roll.
    - To fix this, you have to add the random class call to the fields region.
    - While it was inconvenient for us here to have the problem of the same sequences of numbers with the same seed, it's actually really useful when we need to debug a game that has randomness in it, and we know what seed we started with, because we can perfectly replicate the problem we ran into, by starting the random number generator with the same seed that we had when we identified the problem.
    - We did not use a robust game-level solution to our die problem of random number generators with the same seed.
    - We moved it to be a little less onerous, but we can fix it even better by using a single random number generator for our entire game.
        - And that's really the robust solution, so that anyone who needs a random number, just goes to that game level random number generator to get one. 

<details>
<summary> See Die Class Code Here </summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieClassLecture
{
    /// <summary>
    /// A die
    /// </summary>
    public class Die
    {
        // We first must declare variables for our fields
        #region Fields

        int numSides;
        int topSide;
        Random rand = new Random();

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for six-sided die
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Constructor for die with numSides side
        /// </summary>
        /// <param name="numSides">number of sides</param>
        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets the number of sides
        /// </summary>
        /// <value>number of sides</value>
        public int NumSides
        {
            get { return numSides; }
            // no set cuz we dont want the number of sides to change
        }

        /// <summary>
        /// Gets the Top Side
        /// </summary>
        /// <value>top side</value>
        public int TopSide
        { 
            get { return topSide; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Rolls the die
        /// </summary>
        public void Roll()
        {
            topSide = rand.Next(1, numSides + 1);
        }

        #endregion
    }
}

```
</details>

<details>
<summary> See Main Class Code Here </summary>

```C#
class MainClass
{
    /// <summary>
    /// Tests the die class
    /// </summary>
    /// <param name="args"> command-line arguements</param>
    public static void Main(string[] args)
    {
        // test standard die
        Die standardDie = new Die();
        Console.WriteLine("Standard Die");
        Console.WriteLine("------------");
        Console.WriteLine("Number of sides: " + standardDie.NumSides);
        Console.WriteLine("Top side: " + standardDie.TopSide);

        // roll the die
        standardDie.Roll();
        Console.WriteLine("Top side: " + standardDie.TopSide);
        Console.WriteLine();


        //test d20 die
        Die d20Die = new Die(20);
        Console.WriteLine("D20 Die");
        Console.WriteLine("-------");
        Console.WriteLine("Number of sides: " + d20Die.NumSides);
        Console.WriteLine("Top side: " + d20Die.TopSide);

        Console.WriteLine();

        // roll the die
        d20Die.Roll();
        Console.WriteLine("Top side: " + d20Die.TopSide);
        Console.WriteLine();

        Console.WriteLine();
    }
}

```

</details>