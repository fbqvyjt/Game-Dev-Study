# ***The Input Manager***
Set up and understanding of the Input Manager and how is it useful for those playing our games.

## What is an Input Manager? 🎮
***Input Manager*** → lets one do the following: 
- Map input axes (sin. Axis) to particular inputs
- Check for player input from within a script (important)
- Also lets players remap the input keys to their liking. 

## Now, how do we access it in Unity? 🎮
1. In the Unity UI, go to Edit → Project Settings → Input. The Input Manager will appear in that window.

2. Open up the Axes tab and first Horizontal tab in the window
    - Notice that the left input is the ***negative button*** and the right input is the ***positive button***. 
    - The ***Alt Negative & Alt Positive Buttons*** act as "alternative" buttons for the same functionality.
    - The ***Type*** dropdown displays what kinds of configuration you can use such as gamepad, keyboard, or mouse and keyboard.
    - Notice that there is another ***Horizontal*** dropdown.
        - This allows you to add also a joystick axis configuration.

3. We can also have the player change that mapping but before we can do that we need to actually having a game running

4. Go to "File → Build Settings → Add Open Scenes → Platform → PC...Standalone → Build and Run → create newfolder called "Build", name file "InputManager"

5. Go to the "input" tab when it opens, the player can change the settings by double-clicking. 