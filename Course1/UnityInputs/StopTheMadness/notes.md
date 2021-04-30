# ***Stop the Madness***
Fixing the issues that occured from the "Pushing More Buttons..." section!

## How to Fix the Madness!
The main idea is that we need a ***flag***, a boolean variable, that keeps track of whether or not we had input on the previous frame.

1. Add the field for this right before the `Start()` method.

```C#
//first frame input support
bool previousFrameChangeCharacterInput = false;

```

2. Down in the `Update()` method, add an `else` statement at the bottom after the `if` statement that's checking for that input 

```C#
else
{
    // no change character input
    previousFrameChangeCharacterInput = false;
}
```
3. Because this is a field, not a local variable in the `Update()` method, the next time the method is called on the next frame of the game, this flag is set or cleared. It's true or false.
    - And so, we're actually saving information here for later frames in the game. 
4. The last change we need to make (right before `Vector3 position` is called), is that we only want to change the character

5. BUT! Remember with booleans: Not true is false and not false is true! 
    - Set it to `true` right after the new `if` statement.
    - The flag is now true because next time update gets called (the very next frame in the game), this flag will be set to true.
    - And we will know we already processed that first frame of input. So this will now evaluate to false even though we're still getting input on the ChangeCharacter axis. So we won't try to change the character multiple times. 

```C#
// only change character on first input frame
if (!previousFrameChangeCharacterInput)
{
    previousFrameChangeCharacterInput = true;

    //...
}

```

<br></br>

See Completed Code [Here](UpdatedCharacterChangerScript.cs)