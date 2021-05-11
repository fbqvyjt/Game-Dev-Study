# ***Unity Classes: Designing the Class***
How to design a fish weapon class in the Unity Engine.

## Let's Design a Class, boys and girls!!
1. Let's design a fish class
    - Ranged weapon only, not a melee
    - State
        - Explosion prefab → The fish is stuffed with TNT
        - Damage inflicted by fish
    - Behavior
        - Shoot the fish
    - Identity
        - When the fish script is attached to a game object
    
2. Fish Class Diagram
    - Fields\
        - `damage : int`
        - `prefabExplosion : GameObject`
    - Properties
        - `Damage { get; } : int`
    - Methods
        - `Fire() : void`
3. Reminders as we head to the next section!
    - The classes we design are just abstractions for a particular purpose. 
    - If we were building a fish eating game, stuffing the fish with C4 is probably not a good plan unless you're building a really strange game. So this is just one abstraction of a fish.
