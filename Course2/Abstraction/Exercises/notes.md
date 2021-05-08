# Practice on Abstraction
A couple of practice problems to help grasp the ideas behind Abstraction.

## Problem 1: What is an Apple?
1. Generate a number of abstractions for an apple based on what you plan to do with the apple. Remember, in an abstraction we keep the important details and ignore the unimportant ones.
    - For example, if you plan to eat the apple, the following characteristics might matter to you:
        - Type (Honey Crisp, Red Delicious, etc.)
        - Organic or not
        - Ripeness
        - Quality (number of bruises, worm holes, etc.)
        - Etc.
2. Generate "apple abstractions" for the following uses, capturing all the important apple characteristics for each use:
    - Eat It
    - Throw It
    - Skin It
    - Cook it

### Takeaway:
The most important point here is that there isn't a single "correct" abstraction for an apple; the details that matter depend on how we'll use the apple. Similarly, there's no single "correct" abstraction for anything else we model from the real world or in software (if we're writing code). The details that matter depend on what we need to use the model for.

<br></br>


## Problem 2: Gravity, It's Just a Theory.
1. Unzip files from material and don't look at the Apple.cs file

2. Determine abstraction for the apple
    - In this game, the apple is supposed to provide health to the player (Newton) when the player collides with the apple. Decide what details are important for the apple for this problem.

3. Implement the Apple Abstraction
    - Add the Apple.cs file from the zip file to the scripts folder and attach it to the Apple prefab. [Open the Apple script](Apple.cs) to see the field and property implemented for the apple abstraction for this problem.

4. Add code to [Newton](Newton.cs)
    - Add code to the Newton script to add the amount of health the apple provides and print out the new health to the Console window when Newton collides with an apple. Destroy the apple as well.
    - Remember, you can use the `GetComponent` method to get a reference to a script attached to a game object.