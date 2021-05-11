# ***Unity Classes: Methods***
Implementing the method for our fish class.

### Fish Class Diagram
- Fields
    - `damage : int`
    - `prefabExplosion : GameObject`
- Properties
    - `Damage { get; } : int`
- Methods
    - `Fire() : void`

## Okay! Back to Unity!
1. Before we go over to our script to implement the fire method, we should think a little bit about how we actually want this to work. 
    - We know we want to fire the fish at some point. So, we need to know how we decide when it's time to fire the fish. 
    - Our objective: We'll click on the fish and by clicking on the fish, we'll shoot it
    - The `OnMouseUpAsButton()` method should be our best bet instead of creating our own `Fire()` method since it exists in the documentation.

2. Remove the Start and Update methods provided and write your `void OnMouseUpAsButton()` method.

3. Next, attach a Rigidbody 2D component to your game object in the inspector, and fill in your new mouse method with the code to activate the 2D Physics.

4. You'll need to add a box collider to the fish too because the `OnMouseUpAsButton()` method requires a collider to work. Now that you are all set up, hit the play button on your game!

<details>
<summary> How the Fish Script Should Look Like Right Now </summary>

```C#
public class Fish : MonoBehavior
{
    [SerializedField]
    GameObject prefabExplosion;

    int damage = 100;

    /// <summary>
    /// gets the damage infliced by the fish
    /// </summary>
    public int Damage
    {
        get { return damage; }
    }

    private void OnMouseUpAsButton()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0, 20),
            ForceMode2D.Impulse);
    }
}
```
</details>


