# ***Exploding Teddies, Part I***
How to selectively process game objects using a list and a for loop. In this case, the game object are exploding Teddies.

## There are 6 Different Scripts Used
1. Teddy Bear Spawner (attached to main camera; & from previous lecture)
2. Blowing Up Teddies (attached to main camera)
3. Explosion
4. Teddy Bear
5. Teddy Color
6. Timer

## Important Take Aways from this first lecture
- The "BlowingUpTeddies" Script is by far the most important file in this first lecture, because it's the file that contains all of the actions of what happens when we press one of the buttons on the mouse. See code [here](BlowingUpTeddies.cs).

- Going through a list backwards is always a good idea if you think you might remove elements of the list as you go through the list. 
    - If you go forwards through a list, and remove elements as you go forward, you actually end up skipping over elements of the list, and you certainly don't want that in this scenario.

- The ***Sprite Renderer*** uses the texture supplied in the sprite property, but uses the Shader and other properties from the Material property. 
    - This means that you can use the same material to render different sprites without worrying about what texture is assigned on the material.
    - The null if state prevents us to try and process the main camera.


