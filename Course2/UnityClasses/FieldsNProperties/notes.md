# ***Unity Classes: Fields n' Properties***
Implementing fields and properties in our fish class.

### Fish Class Diagram
- Fields
    - `damage : int`
    - `prefabExplosion : GameObject`
- Properties
    - `Damage { get; } : int`
- Methods
    - `Fire() : void`

## Let's go to Unity!
1. With the provided lecture material, create a new fish script. In it, create a new serialized field for the GameObject prefabExplosion (dont forget to add it in the inspector after saving your code!), and also add your `int` field `int damage;`.
    - We just declare the field, just like we declare variables except we declare it right after the opening curly brace for the class. 
2. Now that the fields have been created, create the properties of this class (in this case just the one), and have its get accessor return the field

3. Now although this will compile fine, we never actually assigned a value to damage.
    - As turns out that in C sharp, and int filled with default to zero but we probably don't want zero for our fish, so let's actually give this value, and let's say it's hundred at this point.
    - So, for items that it hits that have a hundred health, it will be a one shot kill.
    - Certainly as we use our fish in the game, we could decide how to adjust the value for damage so that it integrates well with whatever game we've developed, but we should put some value here and a hundred seems like a reasonable value.

4. To recap, we implemented the field in properties for our fish class, and we also discussed the fact that we need to populate serialized fields in the inspector as we build our fish game object to make sure our fish script works.

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
}
```
</details>