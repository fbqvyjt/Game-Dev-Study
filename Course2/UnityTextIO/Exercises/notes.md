# ***Practice on Unity Text IO***
Implementation on materials learned in the Unity Text IO chapter.

Tasks:
1. Getting Started
- Note: Some of the structure in this exercise matches what you did in Exercise 13. If you want to use that solution as your starting point for this exercise, go ahead; that's what I did!

- Create a new Unity project and save the current scene. Add Edge Collider 2D components to the camera on all 4 sides of the screen. Turn off gravity (in the game). Add a bouncy, no friction Physics Material 2D to all the edge colliders and the Bouncer's collider.

2. Adding A HUD
    - Add a Canvas to the Hierarchy window and rename the canvas HUD. Change the UI Scale Mode in the Canvas Scaler component of the canvas to Scale With Screen Size using a 1280 by 720 Reference Resolution. Add a HUD tag to the HUD canvas.

    - Add a Text component to the canvas and rename it BounceText. Change the characteristics of the Text component so that it's reasonably large, white text centered horizontally near the top of the screen.

    - Create a new HUD script and attach it to the HUD canvas. Open the script in your IDE.

    - Add a documentation comment at the top of the script. Declare a field to hold the `Text` component, marking it with `[SerializeField]` so you can populate it in the Inspector. Remember, the `Text` class is in the `UnityEngine  .  UI` namespace. Go populate the field in the Inspector.

    - Add another field that holds the number of bounces that have happened in the game; initialize that field to 0.

    - In the `Start()` method, set the `text` property of your `Text` field to the number of bounces that have happened in the game. You'll need to use the `ToString()` method to get this to compile.

    - When you run the game, 0 should be displayed near the top center of the screen. Of course, that doesn't change at this point!

    - Add a `public AddBounce()` method that increments the number of bounces that have happened in the game and updates the `text` property of your `Text` field appropriately.

3. Counting the Bounces
    - Implement a Unity class (script) called `Bouncer` that detects when it has collided with something. When it does, it should call the `AddBounce()` method in the `HUD` script. Remember, we can find the HUD by its tag and we can use the `GetComponent<>()` method to get a reference to the `HUD` script attached to the HUD. I added a field and did that work in the `Start()` method so I could easily call the `AddBounce()` method on a collision. You'll also need to get your object moving by adding a force in the `Start()` method.

    - Add a sprite for your Bouncer game object to your project, add the Bouncer game object to the game, and attach a Rigidbody2D, some collider 2D, and your `Bouncer` script as components to the game object.

    - When you run your game, the bounce counter should increase by 1 every time the Bouncer hits an edge of the screen.