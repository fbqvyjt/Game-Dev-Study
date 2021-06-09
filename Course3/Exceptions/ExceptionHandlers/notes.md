# *** Exception Handlers ***
What are exception handlers and why they are important to our programs.

## So what's the REAL reason we need to utilize exception handlers?
- The big idea is we put any code that might throw an exception inside a ***try block***. 
- Then we include one or more ***catch blocks*** to catch specific kinds of exceptions, and we can also include a ***finally block***.
    - That code will get executed whether or not any exceptions were thrown in the try block.

## In Other Words
1. ***Try blocks*** are a place for the prompt to go to if there's an exception error.

2. ***Catch blocks*** retrieve the exception and allow you to call a message to be display explaining the reason for the error. 
- You can call different exceptions that all work as `else if`'s
    - Some examples include:
        - `catch(Exception va)`
            - catches the exception error and can be executed to be written for the prompter
        - `catch(FormatException va)`
            - catches the exception error and allows you to create a string of your choosing describing the exception
        - `catch(OverflowException va)` 
            - catches the exception errors that are over the range given in a prompt and allows you to create a string of your choosing to describe the exception
3. The point of the ***finally block*** is that it always executes whether or not an exception was thrown.
    - We'll discuss this in the File IO Chapter, but it's important to remember that we ALWAYS must close a file when we are done processing it.
    - They are ultimately optional, but if we have some code that we want to always run whether or not we threw an exception, then the finally block is the place to put it.

<details>
<summary> Let's go ahead and create a try block to our code from the last lecture... </summary>

```C#
Using System;

namespace Exceptions
{
    /// <summary>
    /// Exceptions lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // insert try block here
            try
            {
                // prompt for and get a short
                Console.Write("Enter a whole number (-32, 768 to 32, 767): ")
                short input = short.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }
    }
}

```
</details>

<details>
<summary> Now that we have created a try block, let's create a catch block... </summary>

```C#
Using System;

namespace Exceptions
{
    /// <summary>
    /// Exceptions lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // insert try block here
            try
            {
                // prompt for and get a short
                Console.Write("Enter a whole number (-32, 768 to 32, 767): ")
                short input = short.Parse(Console.ReadLine());
            }
            // insert catch with the Exception class, and name of exception object.
            // Note that it looks like a parameter declaration;
            // this is because we are getting info passed into the catch block.
            catch (Exception e)
            {
                // At this point, lets print out the message or
                // explanation of the exception to figure out the next steps.
                Console.WriteLine(e.Message);
            }
            // If you wanted to write out your own exception message,
            // you would do the following:

                // catch (Format Exception fe)
                // {
                //      Console.WriteLine("Not a whole number!");
                // }
            // This will print the string of your choosing.

            // You can also have multiple catch blocks too!
                
                // catch (Format Exception fe)
                // {
                //      Console.WriteLine("Not a whole number!");
                // }
                // catch (OverflowException oe)
                // {
                //      Console.WriteLine("That number is out of range!");
                // }

            Console.WriteLine();
        }
    }
}
```
</details>

<details>
<summary> Now that we have caught the exception, let's use a finally block... </summary>

```C#
Using System;

namespace Exceptions
{
    /// <summary>
    /// Exceptions lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // insert try block here
            try
            {
                // prompt for and get a short
                Console.Write("Enter a whole number (-32, 768 to 32, 767): ")
                short input = short.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Not a whole number!");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("That number is out of range!");
            }

            // This is where you put the finally block
            finally
            {
                Console.WriteLine("All done!");
            }

            Console.WriteLine();
        }
    }
}


```
</details>