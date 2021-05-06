# It's Good Ole Ted the Collector Again!
With what we've learned in iteration, let's make the Ted the Collector game a little more... SPICY!

## Ted the Collector Revisited
Let's make it so that when Ted is going around collecting stuff, if there is an object made closer to him, he will go there first before the other items.

1. The first edit is made to the TedTheCollector Script (only a couple of changes)
    - No longer exposes a targetpickup property, and instead exposes a property called pickups, that provides the list of all the pickups that are in the game.
    - Second, when new pickup is placedm it does all the things it used to, but it also calls the `UpdateTarget()` method on the teddyBear, passing in the pickup that has just been added to the game.

2. The TeddyBear Script, however has a lot of changes.
    - In the `Updatetarget()` method, we now check to first see if our current targetPickup is null, so we make a field that maintains what our current targetPickup.
    - If we do have a targetPickup in the game, we first take our current targetPickup and we get the distance from the teddy bear to that pickup from the method called `float GetDistance(GameObject pickup){}`
    - Now you calculate the distance to the pickup that was just added to the game. If that distance is less that the distance to the current target, we have a new target, because this pickup is closer to us to than our current targetPickup.
        - So we call the `SetTarget()` method, if we dont actually have a targetPickup yet. This method sets the targetPickup, our field, to the parameter that gets passed in here.
    - The `GoToNextPickup()` method calculates the directional information.
        - Once we've found the pickup we were going after, we remove it from the list of pickups in the tedTheCollector script and we stop, and then we GoToTheNextPickup. 
        - We set our targetPickup field to the closest pickup, and we'll look at that method next, because that's the one that actually does some interesting loop processing.
        -  And if the target pickup isn't null, which means there's at least one in the game.
        - Then we go to that targetPickup, and if the targetPickup is null that means there's no pickups in the game and so we stop collecting.
    - The `GetClosestPickup()` method does:
        - First it accesses that new property in TedTheCollector, and puts that list of pickups into a local list of pickups.
        - It declares a couple of variables for the closest pickup and the distance to the closest pickup.
        - And then if that list of pickups has nothing in it, so the count is zero, then we've just returned null.
            - There is no closestPickup, because there are no pickups in the game, and that's why we stop collecting if this method returns null.
            - If it doesn't return null, we start with the assumption that the first element of the list is the closest and we calculate and save the distance to that pickup.
            - And really, we could optimize this by using a for loop that starts at 1 instead of looking at the 0th pickup again because we already have that saved as the closest pickup in distance, but we'll just use a foreach loop here, and what we do is we calculate the distance to the pickup we're currently processing as we iterate over all the pickups that are currently in the game.
            - If the distance to our current pickup is less than the closestDistance we've found so far, we now have a new closestPickup.
            - We set the closestDistance to the distance for this current pickup, and then we move along to the next pickup in the list of pickups. So once we're done going through this foreach loop, closestPickup is the closest pickup in the entire list of pickups.
            - We actually don't care about the distance anymore once we're done with the loop, but we needed it to identify when we found a new closest pickup. 
            - And so we returned the closestPickup that we found.
            - And that is guaranteed to be the closest pickup in the game.
            - Now, if in fact we had two pickups that were exactly the same distance from the teddy bear, the less than will not evaluate to true, so it'll really be the first pick up that we found that was that closest distance.
            - It's going to be a pretty rare occurence, but it's still work fine, it'll just go to the one that it found first.
            - And this pattern of making the assumption that the first element in the list is the closest, and then walking through the list to try to find one that's closer.
            - That's a standard pattern for walking a list, or an array, to find a minimum or a maximum, and so you should make sure that understand this pattern.  
