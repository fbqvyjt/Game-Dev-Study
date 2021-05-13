# ***String Operations***
Various ways to extract information from a string.

## What might we want to do with strings?
1. Convert to a value type
2. Find a particular character
3. Extract part of teh string into a new string
4. Something else(read the documentation to figure out how)

## Let's Go Do Some String Processing in Code!
Here's what we're going to do for our string processing.
1. We're going to read in a comma separated value string,

2. we're going to find the comma location in that string,
    - The first one is the location at which we want to start and we want to start at character zero because we know strings start at character zero. And now we want to provide the length. And one of the thing that's great about zero-based indexing, is we can just provide comma location as the length of the substring.
        - `Substring(Int 32, Int 32)` : "This method retrieves a substring from this instance. 
            - The substring starts at a specified character position and has a specified length." 

3. We'll extract data from the string once we know the comma location,
    - We're going to put it in the percent, and we know we want to substring out of our comma separated value string. This time we need to start at a particular location and go to the end of the string. And that's the other overload of the substring method but we don't want to start at comma location,
        - We want to start at comma location plus one because we don't want to grab the comma as part of the substring, we're grabbing for percent.
    - This won't actually compile successfully. 
    - We've seen that problem before and we even know how to solve it because we can just do float.Parse to parse this into our percent; just like we've used int.parse (there's even a bull.parse and a short.parse, and lots of ways that we can parse from a string into a value type). 

4. and then we'll print the data that we've extracted.


## Here's Our Code with Notes:
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    /// <summary>
    /// String Operations lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates IndexOf and Substring methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // Read in csv string:
            // Because we expect the user to enter this information 
            // in a particular format, 
            // we should tell them what that format is: "(name, percent)" 
            Console.Write("Enter name and percent (name, percent): ");
            string csvString = Console.ReadLine();

            // find comma location (search documentation)
            // we use string method: IndexOf(char) to give us the location
            int commaLocation = csvString.IndexOf(',');

            // extract name and percent
            // we need a method to get a piece of the string
            // documentation: we find the Substring(Int 32, Int 32) method:
            string name = csvString.Substring(0, commaLocation);
            float percent = float.Parse(
                csvString.Substring(commaLocation + 1));

            // print name and percent
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Percent: " + percent;)

            Console.WriteLine();
        }
    }
}