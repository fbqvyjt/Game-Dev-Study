# ***Another Constructor***
How to implement a more general constructor for a die that lets whoever calls the constructor specify how many sides the die will have.

## General Die Constructor Tips
1. When we want to pass information into a constructor, the constructor header needs to have ***parameters***.

2. When we want to pass information into a constructor, the call to the constructor needs to have ***arguments***.

3. If you want to call something from a field within the constructor with the same name, you need to thing of scope.
    - ***Scope** → the visibility of a particular variable or parameter
    - `this.` is a self-reference; a way to refer to the object you are currently in. In this context, we talk about the field.


<br></br>

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

        //test d20 die
        Die d20Die = new Die(20);
        Console.WriteLine("D20 Die");
        Console.WriteLine("-------");
        Console.WriteLine("Number of sides: " + d20Die.NumSides);
        Console.WriteLine("Top side: " + d20Die.TopSide);

        Console.WriteLine();
    }
}

```

</details>