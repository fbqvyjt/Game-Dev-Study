# ***Pushing More Buttons...*** 🖱
Convert mouse button processing to use the input manager.

## From Amateur Mouse to Professional Squeak.E.O!
1. In the CharacterChanger script we made in the first mouse button section, scroll down to the Update() method.
    - In this code, recall that we used the `Input.GetMouseButtonDown()` method in an `if` statement to get this configuration. This time we will utilize the input manager.
2. Open the Input Manager and expand the axes.
3. Add an axes by increasing the size.
4. Change the name of the last new axis created. ("ChangeCharacter")
5. Make the **Positive Button** → "mouse 0", and remove the **Alt Positive Button**. Now you are done in the manager.
6. Back in the script, after looking through documentation, `Input.GetAxis(string axisName)` is the code we want to use that returns the value of the virtual axis identified by `axisName`. 
    - The value will be in the range -1 ... 1 for keyboard and joystick input devices. For mouse the value has to just be > 0.
7. Just change the `if` statement to: 

```C#
if (Input.GetAxis("ChangeCharacter") > 0)
{
    ...
}
```
8. Now run the game!...
9. Oh... huh? WOOPS! Notice anything now?
    - So the code works, its just that we are still cyling through characters too!.
10.  Here's the issue:
    - When we did `GetMouseButtonDown()`, it only gave a `true` on the first frame on which the left mouse button was depressed.
    - However, no matter how fast you press the button, it is detecting input on the change character axis far more than one frame.
        - So more logic will need to be made so that it responds on the first frame of input on that axis. 