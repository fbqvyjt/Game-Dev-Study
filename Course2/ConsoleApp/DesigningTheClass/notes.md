# ***Designing the Class***
Basics on how to design a class in a console application.

## A Couple of Things to Review...

<details>
<summary> Each Object has a: </summary>

* State → Characteristics of an object using fields; provided access by its properties. 

* Behavior → Using methods, we can implement the behavior of an object: The actions it can take on other objects, or itself.

* Identity → The way to distinguish one object from another; this is by their unique memory address

</details>

## Now, let's design a Die Class in our Console App
1. What are we using the die for? Looking for the number on top of the dice to determine something.
    - The State will be the number of sides of the dice stored in fields; accessed through properties
    - The Behavior will be to just roll the die 
    - The Identity will be known once we provide a way to instantiate a die object using constructors.
        - In this example, we will use two constructors: 
            - One that is a standard die,
            - And another that will let us instantiate a die object with a user specified number of sides, like 20
2. Die Class Diagram
    - Fields
        - numSides : int
        - topSide : int
    - Properties
        - NumSides { get; } : int
        - TopSide { get; } : int
    - Methods
        - Roll() : void