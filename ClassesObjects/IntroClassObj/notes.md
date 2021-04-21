# ***Intro to Classes & Objects***
What is an object and class and why is it important in both C# Programming and in Unity.

## Some Definitions to Start with:

1. ***Object*** → a model, or representation of any tangible entity needed within a game such as NPC's, vehicles, grass, items, etc. 

2. ***State*** → characteristics of such object that can be manipulated, moved, rotated... whatever that may to interact with the world its involved with.

3. ***Behavior*** → the abilities of such model → what the object can do to/in the environment, to the player, or to itself.  

4. ***Identity*** → a memory address of that object that allows us to distinguish one object from another.
<br/><br/>

Example Object: ***"A Playing Card"*** 🃏♠
- State: rank, suit, face up or not.
    - Stored in fields (variables inside an object)
    - Accessed through properties
- Behavior: flip over
    - Accessed through methods (some people call them "functions")
- Identity: when we create a new card object (instantiation)

<details>
<summary> Important Object-Oriented Ideas: </summary>

* ***Encapsuation*** → a capsule of the behavior and the data stored in the object's state. 

* ***Information Hiding*** → the consumers of the class get access to properties and behaviors from the outside of the encapsulation, however they do not understand the object as a whole. Dr. T compares it to a "black box".

* Any variable that is declared to be of a class is actually a ***Reference Type*** → the bits in memory are actually a memory address of that variable where it lives rather than it being a value.

</details>
<br></br>

## ***What is the difference between a Class and an Object?***

1. ***Class*** → a template for creating objects that defines the fields, properties, and behavior of every object of the class. (the cookie cutter that shapes all the cookies)

2. ***Object*** → an actual instance of the class in memory.
    - Each object stores its own state
        - Different card objects have different ranks and suits, for example.

3. ***UML*** → "Unified Modeling Language" → this is the standard representation of a class.
    - We use UML to build a model of our software
        - It is like a graphical language, and its a notion that unified a number of different object-oriented notations.

Card (class)
- Fields
    - `faceUp : bool`
    - `rank : string`
    - `suit : string`
- Properties
    - `FaceUp { get } : bool`
    - `Rank { get } : string`
    - `Suit { get } : string`
- Methods
    - `FlipOver() : void`

