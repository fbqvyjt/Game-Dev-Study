# ***Text Output***
How we can output text in a Unity game.

## Why is Text Output Important?
- This is really useful if we want to convey information, like a score, for example, to the player.
- We need a ***canvas*** if we're going to include Unity UI components in our scene. 
- We can also add and use a text component to provide textual information to the player. 

## How do we do this?
1. Right-click on the Hierarchy window, and add a UI component and add the Canvas. Rename the canvas: "HUD"
2. Right-click "HUD" and create a UI element called Text and call it "ScoreText".
    - In that element on the left, you can make changes to the font, color and various adjustments to display it on the screen at the top for the score.
3. The Canvas scaler should be scale with screen size that provides a reference resolution, such as 1280 x 720 (16:9)

4. Create a script for your HUD and be sure to drag it to the HUD UI, and also make sure to have serialized fields to hold the ScoreText and drag it over to its prospective spot in the Inspector as well.

<details>
<summary> HUD Script code </summary>

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NEW USING DIRECTIVE 
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehavior
{
    // scoring support
    [SerializeField]
    Text scoreText;
    int score;
    const string ScorePrefix = "Score: ";

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // can use the "text" property to change,
        // that is the text that will be displayed
        scoreText.text = ScorePrefix + score.ToString();
    }

    /// <summary>
    /// Adds the given points to the score
    /// </summary>
    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score.ToString();
    }
}
```
</details>

5. So if we run the game, You can see that the `Start()` method concatenated to that score prefix with 0 from my score because that's my score right now. The last piece we need to add is when the fish eats a teddy bear, it should tell the HUD to add points to the score. So we'll do this in a couple of steps:
    - Now to call the method on that HUD script, we're going to need to have a reference to that HUD script.
        - We might as well get the reference and save it in a field, so we don't have to look it up every time the fish eats a teddy bear. So I'm going to save here a reference to the HUD. We also need to have a constant for howw many points a bear is worth: lets say 10. And now in the `Start()` method, we will save a reference to the hud.
    - Be sure to add a game tag to the HUD back in the editor
    - In the Start method, I'm getting a reference to that HUD script, so that in the `OnCollisionEnter2D()` method, if I'm actually destroying a teddy bear here,
I can call the hud.AddPoints method,
with the BearPoints. 

<details>
<summary> Before the Start Method Fish Script </summary>

```C#

// scoring support
HUD hud;
const int BearPoints = 10;

```
</details>

<details>
<summary> At the End of the Start Method in Fish Script </summary>

```C#
void Start()
{
    // ...
    // ...
    // ...

    // save a reference to the hud
    hud = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>();
}
```
</details>

<details>
<summary> Then in the OnCollisionEnter2D() Method </summary>

```C#

// destroy teddy
if (coll.collider.bounds.Intersects(headBoundingBox))
{
    hud.AddPoints(BearPoints);
    Destroy(coll.gameObject);
}

```
</details>

6. Result: So this is an example of using a pretty standard pattern where we have a HUD to display information to the player and GameObjects can interact with the HUD to update that information.

