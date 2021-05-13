# ***String Basics***

## What is a String? and Some Notes About Them
- ***String*** → is just a sequence of Unicode characters, chars; and it is a reference type. 
- ***Index*** → a character location within a string
    -  Because a string is a sequence of characters, we can access a particular character in the string by putting its index between square brackets, and if that looks a lot like accessing an element of an array, that's because you're essentially accessing a character in the array of characters that is a string. 

## What we've learned from String Basics!
1. Read a string from the console and put it into a string variable,

2. Saw what we have done before reading a string and passing it so we can put it into a numeric variable

3. Saw how to extract a particular character from the string and put it into a character variable.


<details>
<summary> See Code Here </summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    /// <summary>
    /// String Basics lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Desmonstrates string basics
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // prompt for and read in gamertag
            Console.Write("Enter gamertag: ");
            string gamertag = Console.ReadLine();

            // prompt for and read in high score
            Console.Write("Enter high score as a whole number: ");
            int highScore = int.Parse(Console.ReadLine());

            // extract the first character of the gamertag
            char firstGamertagCharacter = gamertag[0];

            // print out values
            Console.WriteLine();
            Console.WriteLine("Gamertag: " + gamertag);
            Console.WriteLine("High Score: " + highScore);
            Console.WriteLine("First Gamertag Character: " +
                firstGamertagCharacter);

            Console.WriteLine();
        }
    }
}
```
</details>

## Some Additional Information!
- Strings are immutable. ***Immutable*** means that the string can't be changed. Once we've created it, we can't change the string.
    - If we actually need a string that we can manipulate, we use a different class called a `StringBuilder` to which we can add and remove characters and so on. But once we build a string, it's immutable.