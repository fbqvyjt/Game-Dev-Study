# ***Exploding Teddies, Part II***
Using a list, a for loop, and a Unity feature called tags. 

Tags: Where to Find? 
- Edit → Project Settings → Tags and Layers
- If you want to see all of the game tags, click any object, and click the dropdown of tags in the inspector at the top. 

## Why is this important
- We want to tag each of our Teddies to their prospective  
- Tags are actually just strings; they label certain properties that are attached to the game object. They are **NOT** the enumeration itself.
- Tags are REALLY helpful because they ultimately can help us condense our dense code, so to speak.

### In this Section Folder, you can find two modified scripts.
-  The Main difference is that there is now more consise code for the Blowing Up Teddies file and the Teddy Bear Spawner file. This is the power of Tags:

- The first file that is condensed is the TeddyBearSpawner script.
- When we spawn a teddyBear, remember we have randomly been picking a sprite for that teddyBear. So it might be green or purple or yellow.
    - And what we will do in addition to setting the sprite is we will also set the tag for the teddyBear.
- We're building a green teddyBear, so we'll set the tag to be the `TeddyColor.Green` enumeration value.
- But tags are actually strings, not enumerations, so we need to convert this enumeration to a string by calling the `ToString()` method on it.
- And so now the tag for this teddyBear will be green, and we do the same for purple, and the same for yellow.
- See updated code for the TeddyBearSpawner script [here](TeddyBearSpawner.cs)

- Our `BlowUpTeddies()` method is significantly simpler, because we don't have to gather all the game objects in the game. 
    - And make sure they have a sprite renderer to make sure we don't get a null reference exception on the main camera. And then filter by color to decide when to call BlowUpTeddy. 
    - It's much simpler. We still clear the list of gameObjects, and we still call AddRange.
    - But this time we're calling the gameObject `FindGameObjectsWithTag` method.
    - And the tag that we're looking for is the color that got passed in, again converted to a string because tags are not the `TeddyColor` enumeration, they're strings.
    - But what this method returns is only the teddyBears that are tagged with the color we were looking for.
    - So now we can just do a for loop, a backwards for loop, over that list
        - Because we know that list is now just yellow teddyBears, for example.
    - And we blow up each of them.
    - So using these tags really simplifies the coding we need to do to get the same game behavior we had before.
    - See updated code for the BlowingUpTeddies script [here](BlowingUpTeddies.cs)