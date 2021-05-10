# ***One Constructor***
Implementing a constructor for a standard six-sided die.

## Six-Sided Die Constructor Tips
1. The name of the constructor is always the name of the class.
2. You then put parenthesis whether or not we have parameters for the constructor, and this particular constructor doesn't. 
3. We then make the number of sides equal to six and the top side equal to one.

<details>
<summary> See Code Here </summary>

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
        public Die()
        {
            numSides = 6;
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

4. Now that have the constructor implemented, in the `Main()` method, we set up code to test our standarad die.

<details>
<summary> See Code Here </summary>

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

        Console.WriteLine();
    }
}

```

</details>