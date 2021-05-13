# ***Text Input***
How to use an InputField to get text input from the player.

## Why?
- It's really useful if we ever need the player to type something in like their gamertag.

## Let's Take a Look!
1. We create a `PrintGamertag` script and attach it to the Main camera. Its populated by the gamertag text component on the canvas, so that we can acces that component from inside the script.

2. In the script
    - I do a typical make-it-so-we-can-populate-it-in-the-inspector-with-a-SerializeField.
        - We save a reference to the InputField component that's attached to that
    - We create a simple timer that just keeps track of whether it's time to display the gamertag again.
        - Notice in the `Start()` method, for efficiency, we take that gamertagText game object and getting its InputField component.
    - And in the `Update()` method,
        - All we do is update the timer and say whether or not it's time to display again, and if it is, I reset that timer, and I print out whatever the text value is of that text component.
    - So we don't have to do any extra processing in my script here to notice that the player has used the InputField to change their gamertag.
    - We can access gamertag.text at any time to get the current value of that text field no matter how many times the player has actually changed it by selecting it and typing and then pressing enter to stop editing the text field. 

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Prints the gamertag every second
/// </summary>
public class PrintGamertag : MonoBehaviour
{
	// make visible in Inspector
	[SerializeField]
	Text gamertagText;

	// saved for efficiency
	InputField gamertag;

	// output gamertag once per second support
	float secondsSinceLastOutput = 0;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		gamertag = gamertagText.GetComponent<InputField>();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {	
		// output gamertag every second
		secondsSinceLastOutput += Time.deltaTime;
		if (secondsSinceLastOutput > 1)
        {
			secondsSinceLastOutput = 0;
			print(gamertag.text);
		}
	}
}
```



