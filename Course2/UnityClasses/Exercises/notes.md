# Practice
Implementation on materials covered in the Unity Classes Chapter.

## The Bouncer
1. Getting Started
    - Create a new Unity project and save the current scene. Add Edge Collider 2D components to the camera on all 4 sides of the screen. Turn off gravity (in the game). Add a bouncy, no friction Physics Material 2D to all the edge colliders and the Bouncer's collider.

2. Bouncing is Deadly
    - Implement a Unity class (script) called `Bouncer` that keeps track of its health and destroys the game object it's attached to when its health reaches 0 (or below 0). Reduce the health by 10 whenever the object collides with something. You'll also need to get your object moving by adding a force in the `Start()` method.
    - Add a sprite for your Bouncer game object to your project, add the Bouncer game object to the game, and attach a Rigidbody2D, some collider 2D, and your `Bouncer` script as components to the game object.
    - When you run your game, your Bouncer should be destroyed when it hits an edge of the screen for the tenth time.

3. Fading Away
    - Let's add some visual interest, where the game object fades a little on each bounce until its destroyed.
    - When you reduce the health, reduce the alpha value of the color for the SpriteRenderer by 0.1f also. You'll need to explore the `SpriteRenderer` and `Color` documentation to figure this out. The alpha component of a color is how opaque it is, with 1 meaning fully opaque and 0 meaning fully transparent.


- See Script Code [Here](Bouncer.cs)