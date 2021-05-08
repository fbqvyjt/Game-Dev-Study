# ***Collision-Free Spawning***
How to use a while loop to make sure that we spawn into a collision free location.

## Why is this an important step in spawning your game objects? 
1. Well, for starters, it would be really inconvenient if we had so many objects that theres no space for the game object to spawn where it would be free from a collision with another object (this can be seen in the code in the TeddyBearSpawner script [here](TeddyBearSpawner.cs)).

2. Another important reason you would want to ensure your objects spawn collision-free is that fact that is that if you don't create a set number of spawning objects, you might risk the project running infinitely or in an infinite loop/

3. Lastly, from a player's POV, this will allow you to control how you want the overall gaming experience is to be for the character. Think of Doom, if a whole bunch of demons spawned right in front of you, would you start to feel some anxiety? On the flip side, if theres no enemies nearby, and its dark and lonely like Phasmophobia, wouldn't you be more terrified if a single ghost object spawned right next to you?


## From those points, how can we ensure that?
1. So we make sure that we set a number of times to spawn. If it's not possible, we have it stop. This is to prevent an infinite loop situation.

2. Another way to prevent this is to ensure we have a consistent width and height of the game object. In this case lets save the object collider half width and half height to set the area that we'd want to check for a collision.
    - We store it once and then we have two vector2s to check for in the collision, we have min and max,
        - min will be the upper left corner
        - max will be the lower right corner
    - Instead of creating a new vector2 for each of those each time, we'll just create it here and set the X and Y properties for each of those as appropriate when it's time to check.

3. Within the start method of this script, we instantiate a prefab teddy bear, we get its collider, we calculate the half width and half height and then we destroy that temporary teddy bear.
    - So, rather than hard coding the dimensions of the collider, we can just spawn one and check.
    - In that way if somebody later on decides to change the size of that collider, then this code will still work fine even though that's been changed. 

4. The `spawn bear()` method gets called each time the spawn timer goes off or finishes.
    - So, what we do is we generate a random location and all this we've been doing all along when we spawn teddy bears.
    - The new method call, `SetMinAndMax` is for a given world location,
and that method just does what I said earlier, it just sets x, y for min,and x and y for max to be corners based on the dimensions of the teddy bear collider and the location at which we're thinking of spawning a teddy bear. 

5. Just before the while loop, we first set spawnTries a local variable to one because we're only going to try a certain number of times and then give up, remember to avoid that infinite loop. And then we want to use this method called OverlapArea in the Physics2D class.
    - The `OverlapArea()` method passes in two vectors: a pointA and a pointB; it also returns a Collider2D and if there isn't a collider in the area, the class returns null.
    - So in the code `while (Physics2D.OverlapArea(min, max) != null && spawnTries < MaxSpawnTries){}`, as soon as the first part of this boolean expression is false, in other words, the method returns null, and null not equal null returns false, as soon as that's false, because were using an and, we drop out of the while loop.
        - We also drop out of the while loop if spawnTries is no longer less than MaxSpawnTries because that would mean that we've tried enough and its time to give up.
6. Inside the while loop, this is the code if there is a collision.
    - We generate a new location, setting min and max again and then we increment `spawnTries` because we want to keep going up until we get to `MaxSpawnTries` and eventually either we drop out of the loop because we found a collision free location or we drop out of the loop because we tried 20 times and it's time to give up.
    - We need to check if the min and max that we ended up with was actually a collision free location because it's possible that we gave up after 20 tries and the min and max are in fact still a collision location.


