# ***Colliders & Physics Materials***
What is collision detecton and resolution, and how are colliders and physics materials utilized in Unity?

1. ***Collision Detection*** →  detecting a collision(s) between two game objects in a scene.
    - Easy to work in Unity!
        - Just attach 2D colliders to the game objects and then 2D physics.

2. ***Collision Resolution*** → giving an action or response to the collision; resolving the collision we've detected doing something in response to that collision.
    - As long as we add materials to our colliders, we can have the physics engine determine how that collision gets resolved (how the objects bounce off of each other, or not, for example, based on friction and bounciness for the colliders).
    - We can also implement our own collision resolution in case we want to do something else (reduce health as a result of the collisions and such).