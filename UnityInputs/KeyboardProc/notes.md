# ***The Keys to Input: Keyboard Processing***
Using the keyboard for inputs in Unity games.

## Keyboard Processing
1. In the Input Manager, we are going to utilize the Horizonal and Vertical Axes, so make sure to have those open
2. In the `Update()` method in the Character Script, we should push the game object around by reading the input and moving the character around.
    - We have to set up a constant after the floats we called just under the class name.

```C#
// movement support
const float MoveUnitsPerSecond = 5;

```
3. Back in the `Update()` method, we need to make some changes to accomodate for keyboard inputs rather than the mouse.
    - We need to call the inputs and have their positions for both axes:
        - `position.axis += axisInput * MoveConstantPerSecond * Time.deltaTime;`

```C#
void Update()
{
    // move based on input
    Vector3 position = transform.position;
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");
    if(horizontalInput != 0)
    {
        position.x += horizonalInput * MoveUnitsPerSecond *
            Time.deltaTime;
    }
    // for vertical use still if statement so both can be moved in the same frame
    if (verticalInput != 0)
    {
        position.y += verticalInput * MoveUnitsPerSecond *
            Time.deltaTime;
    }

    // move character to new position and clamp in screen....
}

```

4. When you run the game, you can move the character with the keys.
    - However, notice that if you go diagonal, you will actually move faster than if you were to move up and down.
    - This is a famous bug from "Doom' called "The Strafe 40 Bug"
    - Looking back at the code, if both the vertical and horizontal axis are called, then the constant `MoveUnitsPerSecond` is actually not equal to 5, but in fact equal to 5 time 2**2. This is from the Pythagorean theorum. We won't fix it for now, however we still need to make some changes in the Input Manager.

5. Back in the Input Manager in the editor, lets make the **Alt Positive Button** the "space bar" to change the character.