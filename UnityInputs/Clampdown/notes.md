# Clash of the Clamps
How to clamp the game object so that it stays within the screen.

Some Definitions:
1. ***Clamp*** → word to describe how to hold/clamp onto a particular value within a range of values, or a specified set of values to stay valid.

2. ***ScreenUtils*** → a static class that doesn't inherit from MonoBehavior, that allows for characters to recognize the properties of the screen.

3. ***Initializer*** → a method that initializes a class. In this context, the ScreenUtils is whats initialized.

## ***Note!*** 
- This section is more focused on the conceptualization of how a clamp functions. Most of the code from the lecture was (supposed to be) provided for and the purpose of the ScreenUtils and Initializer are more important than what is in them (FOR THE TIME BEING).

<details>
<summary> The Code for keeping the Character in the view of the Camera </summary>

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