# ***Practice for Exceptions Chapter***
Utilization of exceptions materials.

## The User is Crazy!
1. Get user input
    - Start up your IDE and create a new Console Application project named Exercise1. Save the project in a reasonable location on the computer.
    - Add code to the `Main` method to prompt for and read in an integer score from the user.
    - Run your code with a normal input, non-integer input (Bob, say), and a number larger than the maximum integer (2,147,483,647). 
    - See how the program throws exceptions for the second two inputs. You can use Ctrl+C in the Command Prompt window to get past the exception.
2. Add try and catch blocks
    - Put the prompting and reading in code inside a try block.
    - Add a catch block for a `FormatException`, printing an appropriate error message inside the catch block. Run your code with non-integer input; you should see the error message.
    - Add a catch block for an `OverflowException`, printing an appropriate error message inside the catch block. Run your code with a number larger than the maximum integer (2,147,483,647); you should see the error message.
3. Add a finally block
    - Add a finally block that prints a message.
    - Run your code with a normal input, non-integer input (Bob, say), and a number larger than the maximum integer (2,147,483,647).
    - The error messages for the two invalid inputs should still be displayed and in the message from the finally block should be displayed for all three inputs.

<details>
<summary> What your code should look like... </summary>

```C#
using System;

namespace Exercise1
{
    class Program
    {
        /// <summary>
        /// Demonstrates exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // prompt for and get score
                Console. Write("Enter score (as a whole number): ");
                int score = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That's not a whole number!");
            }
            catch (OverflowException fe)
            {
                Console.WriteLine("That number is out of range!");
            }
            finally
            {
                Console.WriteLine("GG");
            }

            Console.WriteLine();
        }
    }
}
```
</details>