# ***Properties on the State***
Terminology and implementation on properties of an object

### Remember:

- A ***Class*** is a description of a group of objects with common properties, behaviors, and relationships. A class is an abstraction(the most important aspect), while an object is an instance of a class.

<br></br>

## ***What are the properties of an object?***
1. ***Properties*** → Information on an object's state. Any characteristic or attribute which can be quantitatively evaluated.
    - e.g. : Pressure, temperature, velocity, energy
    - In good object-oriented programming, consumers of the class cannot access the fields that store the state directly, they go through properties instead.
    - The `Deck` class contains a property called `Deck.Empty{ get; }` 
        - If a property lists `{ get; }` → we can read it.
        - If a property lists `{ set; }` → we can write it.
        - If a property lists `{ both; }` → we can both read and write it.
    - See how this `Deck.Empty{ get; }` code is used [here.](PropertyPrac.cs) 

2. `bool` → a data type that can only be True or False.