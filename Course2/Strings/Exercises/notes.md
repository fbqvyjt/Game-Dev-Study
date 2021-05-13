# Practice
Implementation of material covered in the String Chapter.

## Yer Birthday
1. Birthday Fun
    - Create a new console application named Exercise14. Your program will read in a user’s birthday as a month (January, February, etc.) followed by the day and echo that information to the user. 

    - Start by prompting for and getting the month of the user’s birthday

        - Print an appropriate message to the user asking for their birth month
        - Read the value from the user
        - Store the value in an appropriate variable

    - Next, prompt for and get the day of the user’s birthday

        - Print an appropriate message to the user asking for their birth day
        - Read the value from the user
        - Convert (Parse) the value as appropriate. You should NOT be storing the day as a string!
    - Store the value in an appropriate variable

    - Finally, print out the stored values to the user with an appropriate message

2. Reminders
- Add code to display what day a reminder email will be sent to the user inviting them to visit an in-game store on their birthday for 20% off.  Your program must display that the reminder will be sent on the day before the user’s birthday. 

- Specifically, your additional code should print a message to the user stating the month and day they will receive a reminder (see Hint below).

- Hint:  What if the user puts in the first day of the month (e.g., July 1)?  What value will your application print?  This is a bug!  We won't worry about that here as we practice with strings, so leave the bug and ignore the problem.

<details>
<summary> See Solution Code Here </summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    /// <summary>
    /// Exercise 13 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets birthday and prints reminder
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // get birth month and day
            Console.Write("In what month were you born? ");
            string birthMonth = Console.ReadLine();
            Console.Write("On what day were you born? ");
            int birthDay = int.Parse(Console.ReadLine());

            // print birthday
            Console.WriteLine();
            Console.WriteLine("Your birthday is " + birthMonth + " " + birthDay);

            // print reminder message
            Console.WriteLine("You'll receive a reminder on " + birthMonth + " " + (birthDay - 1));

            Console.WriteLine();
        }
    }
}
```
</details>

<br></br>

## It's the the CSVs for Me
1. Extracting the Pyramid Slot Number
    - Create a new console application named Exercise15.

    - Read in a string from the user in the following format:

    `<pyramid slot number>,<block letter>,<whether or not the block should be lit>`

    - Example:
        - 15,M,true

    - Use the `String()` methods you can read about in the documentation to extract the pyramid slot number from the string and store it in a variable.

    - Print the pyramid slot number. This is a number, so you should NOT be saving it as a string!

2. Extracting the Block Letter
    - Extract the block letter from the string and store it in a variable.
    - Print the block letter. This is a single character, so you should NOT be saving it as a string!

3. Extracting Whether Or Not the Block Should Be Lit
    - Extract whether or not the block should be lit from the string and store it in a variable. This is a Boolean value, so you should NOT be saving it as a string\tt{string}string!

    - You are NOT allowed to use the `LastIndexOf()` method to do this. (Hint: Use the `Substring()` method to shorten the original input string)

    - Print whether or not the block should be lit.

<details>
<summary> See Solution Code Here </summary>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
     /// <summary>
     /// Exercise 14 solution
     /// </summary>
    class Program
    {
        /// <summary>
        /// Extracts and prints block information
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // prompt for and read in string
            Console.Write("Enter <pyramid slot>,<block letter>,<true or false for block lit>: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            // extract and print pyramid slot number
            int commaLocation = input.IndexOf(',');
            int slotNumber = int.Parse(input.Substring(0, commaLocation));
            Console.WriteLine("Slot Number: " + slotNumber);

            // extract and print block letter
            char blockLetter = input[commaLocation + 1];
            Console.WriteLine("Block Letter: " + blockLetter);

            // extract and print whether or not the block should be lit
            string temp = input.Substring(commaLocation + 1);
            commaLocation = temp.IndexOf(',');
            bool lit = bool.Parse(temp.Substring(commaLocation + 1));
            Console.WriteLine("Block should be lit: " + lit);

            Console.WriteLine();
        }
    }
}
```
</details>
