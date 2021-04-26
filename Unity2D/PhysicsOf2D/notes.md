# ***Let's Get Physical: 2D Physics***
How to add 2D physics to a game.

How to Add the 2D Physics Component: 
1. Select Desired game object.
2. In the inspector Window, press the "Add Component" button
3. Select "2D Physics" and then select "Rigidbody 2D"
    - [Link to Scripting Reference page.](https://docs.unity3d.com/ScriptReference/Rigidbody2D.html)
4. Next, set gravity to 0:
    - "Edit" (Upper Tab) → "Project settings" → "2D Physics" → "Gravity" (set to 0 in y)
5. Now let's apply a force:
    - Add a new moving script → "Mover"

### ***REMEMBER:***
- Scripts are components, and the scripts that we attach as a component to a game object is actually an object, it's an instance of the script class.
- In the same way, the rigid body 2D component that we have attached to our UnityBoi is in fact an instance of the rigid body 2D class and we can get a reference to that object by doing: ↓

``` C#
void Start()
{
    // get the game object moving
    Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
    rb2d.AddForce(new Vector2(1,0),
        ForceMode2d.Impulse);
}
```
<br></br>

## ***Another way to do it:***

``` C#
void Start()
{
    // get the game object moving
    GetComponent<Rigidbody2D>().AddForce(
        new Vector2(1,0),
        ForceMode2D.Impulse);

}
```
