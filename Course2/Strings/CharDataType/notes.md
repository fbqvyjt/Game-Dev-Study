# ***The Char Data Type***
Learning about a value type that lets one store a single character.

## What is a Char?
- `char` → uses 16 bits of storage that stores a single Unicade characters.

- So, a ***string literal*** which we've been using ever since we started printing stuff out using ConsoleWriteLine, appears between double quotes`" "`, but a ***character literal*** appears between single quotes `' '`.


```C#
// prompt for and get choice
Console.Write("Enter your choice (N, L, O, or Q): ");
char choice = Console.ReadLine().ToUpper()[0];
Console.WriteLine();

// print message
if (choice == 'N')
{
    Console.WriteLine("Creating new game ... :");
}
else if (choice == 'L')
{
    Console.WriteLine("Loading game ...");
}
else if (choice == 'O')
{
    Console.WriteLine("Setting options ...");
}
else if (choice == 'Q')
{
    Console.WriteLine("Quitting game ...");
}

```