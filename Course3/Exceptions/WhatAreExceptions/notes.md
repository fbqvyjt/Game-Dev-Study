# ***What are Exceptions?***
Defining Exceptions and why they need to be taken care of in C# Programming and Unity.

## Exceptional Exceptions
- With out ***Exceptions***, our program will crash and burn into oblivion! :D Fun stuff, right?
    - **Note**: unhandled exceptions dont typically crash Unity games, they most definitely crash console apps.

## Let's take a look at an example... </summary>

```C#
...
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
        // prompt for and get a short
        Console.Write("Enter a whole number (-32, 768 to 32, 767): ")
        short input = short.Parse(Console.ReadLine());

        Console.WriteLine();
    }
}
```

## Recap: So What's going on?
1. So far, if you were to run this code and add a whole number, nothing would happen.
2. However, if you entered anything other than a whole number, you will get an "unhandled exception error" and the program WILL CRASH.
3. They don't usually crash our Unity games because the Unity engine already has a lot of built-in exception handling
    - If exceptions are getting thrown in your Unity games, they're probably not going to work the way you expect them to. 