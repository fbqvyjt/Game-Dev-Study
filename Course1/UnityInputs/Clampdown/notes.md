# ***Clash of the Clamps***
How to clamp the game object so that it stays within the screen.

Some Definitions:
1. ***Clamp*** → word to describe how to hold/clamp onto a particular value to be within a range of values, or a specified set of values to stay valid.

2. ***ScreenUtils*** → a static class that doesn't inherit from MonoBehavior, that allows access for consumers of this class (in this case, the characters) to recognize the properties of the screen.
	- Creating a ScreenUtils script, helps the efficiency of your work and prevents you from having to add this code to each of the characters → its a place for the characters to easily access and lessen the ammount of work.

3. `.Initialize()` → a method that initializes a class. In this context, the ScreenUtils is whats initialized.

4. `void Awake(){}` → a method that is called before Start.

## ***Note!*** 
- This section is more focused on the conceptualization of how a clamp functions. Most of the code from the lecture was (supposed to be) provided for and the purpose of the ScreenUtils and Initializer are more important than what is in them (FOR THE TIME BEING).

<br></br>

## ***So how do we actually prevent the character from going outside the camera collider?***

1. Well, first you have to save half the collider's width and half it's height.
	- The reason for this, for example, is that if we want to determine if the character outside the left-hand side of the screen. We take the location of the character and we subtract half the collider width.
		- If that left edge of the character is less than the left edge of the screen, then we've exited the screen a little bit. 
		- So we will need to bring the character back into the screen to clamp the character to stay inside of that screen
2. In the `void Start()` method, we will first call the `BoxCollider2D` collider from the character, save it as a variable (in this case `collider`), and then calculate the colliderHalfWidth as the horizontal size and also the colliderHalfHeight as the vertical size divided by 2. 

3. Moving on to the `void Update()` method, its time to write the behavior of the character following the mouse around using the code we used in the previous section
	- The only difference here is that before we end the `void Update()` method, we call the next method `void ClampInScreen()` to verify that as we go through each frame, we check that it is within the screen. 

4. Finally, we write the Clamp.
	- Here the code can get a little monotonous, but the key thing to remember is to make sure the each side of the screen is accounted for: left, right, top, bottom. 
5. The last bit of code we need to do is save the current position into position variable → `Vector3 position = transform.position;`
6. Lastly we need to check ***if*** the characters position in relation to the edge of the screen.
	- How do you check? Well... the bold word might give it away... `If` statements of course, silly!
	- Within these `if` statements, you are going to have to refer the position + or - the colliderHalfWidth or colliderHalfHeight in relation to the `ScreenUtils` script: 
	
	```C#
	if (position.x - colliderHalfWidth < Screen.ScreenLeft`
	{
		position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
	} 
	```
7. Make sure at the very end of the `ClampInScreen()` method, that you set the position to transform the position.

<br></br>

<details>
<summary> Let's See How this is all written in the Character Script </summary>

```C#
// saved for efficiency
	float colliderHalfWidth;
	float colliderHalfHeight;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		BoxCollider2D collider = GetComponent<BoxCollider2D>();
		colliderHalfWidth = collider.size.x / 2;
		colliderHalfHeight = collider.size.y / 2;
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
    {
        // convert mouse position to world position
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);

        // move to mouse position
        transform.position = position;
		ClampInScreen();
    }

	/// <summary>
	/// Clamps the character in the screen
	/// </summary>
	void ClampInScreen()
    {
		// clamp position as necessary
		Vector3 position = transform.position;
		if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
		{
			position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
		}
		else if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
		{
			position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
		}
		if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
		{
			position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
		}
		else if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
		{
			position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
		}
		transform.position = position;
    }
```
</details>