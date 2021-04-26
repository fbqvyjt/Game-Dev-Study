# ***Sprites and Game Objects***
How to add sprites to your game and how to add game objects to the scenes in your game.

1. ***Sprites***
    - Sprites are graphical assets that can be a single image, or a set of images that are used in the animation of a game object. 
        - The single image is called a ***frame***
        - A set of frames (or images) is called a ***sprite sheet*** or a ***sprite strip***.

2. ***Game Objects***
    - Game objects are the entities within the game.
    - These are added to a scene in Unity and then that game object is a thing that behaves within the context of the game world.

3. How to attach a sprite to a scene
    - EASY PEESY MAN! Make a folder in your project called "Sprites" and drag the item to this new folder from where its stored in Windows Explorer.
    - Next, just drag it to your scene (or create a folder with such prospective file). ALL DONE! ❤

4. Sprites in Unity
    - The item might be really tiny...
        - if that's the case, you can simply either use the little knobs on the edges of the sprite to enlarge the image or edit the scale of the sprite in the Inspector. However that's not always wise as the image will become blurry.
    - What you need to do is actually select your main camera and change its size to 3 instead of 5
        - You should know the standard sizes of the images before you have them done so not to have art that can't fit properly in the game.
            - artworks should be a power of 2 when you design the size. this is to allow the graphics card to process properly.