# Intro to Inputs: Mouse Location Process
What are inputs and how can we process mouse inputs?


## ***Let's Learn How to Add Inputs to Play Our Games!***
1. Make a folder for scripts with a new C# script called Character. 
2. Drag this file to the prefabs that have already been made.
3. Opening the script, "Character":
    - Yay! We finally get to write code in the update method!
    - What we want to do is on every fram, we want to find out where the mouse is and then we want to move our character to that same position.
    - Find the information in documentation about mouse location.
4. Looking in the documentation:
    - We determin that the input mousePosition value gives us the current position of the mouse in screen coordinates.
    - REMEMBER!! We have Screen coordinates & World Coordinates! They are not synonymous. 
    - ***Screen Coordinates*** → pixels in the screen space, the coordinates in 2D with (0,0) being the bottom-left, and (pixelWidth,pixelHeight) the top-right. The z position is in world units from the camera.
    - ***World Coordinates*** → are the coordinate in which game objects live in a world space in 3D.
    - To have screen coordinates translate to world coordinates, we need to use the `Camera.main.ScreenToWorldPoint()` method, with its only parameter being the position.
    - This method transform a point from screen space into world space, where world space is defined as the coordinate system at the very top of your game's hierarchy. Screenspace is defined in pixels

<br></br>

<details>
<summary> Here's How This Can Be Implemented in Code </summary> 

``` C#
void Update()
{
    // convert mouse position to world position
    Vector3 position = Input.mousePosition;
    position.z = -Camera.main.transform.position.z;
    position = Camera.main.ScreenToWorldPoint(position);

    // move to mouse position
    gameObject.transform.position = position;
}
```

</details>

