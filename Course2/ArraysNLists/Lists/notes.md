# ***Lists***
How can we use lists and how they differ from arrays?

## How can arrays become problematic in writing games?
1. Arrays have a big limitation: 
    - We have to know how many elements we're going to have in the array when we create the array object.
    - sometimes that's problematic in games, because we will regularly spawn and destroy objects.
    - So an array is a problem because it has a set number of elements. 

## Lists
1. ***Lists*** → Like array objects, we can store anything, but a particular list can only store a single data type. The difference is that we don't need to know the size.
    - They can be found in the `System.Collections.Generic` namespace.
2. Collection Classes (including lists) hold collections of elements.

### Using the Code from the Array in Practice Lection Lets do the same but with lists:

```C#
public class CharacterChanger : Monobehavior
{
    /// <summary>
    /// Changes character on left mouse button
    /// </summary>

    // notice the list call looks a little different. 
    // remember we dont need the size of items in the list.
    List<GameObject> prefabCharacters = new List<GameObject>();

    // need for location of new character
    GameObject currentCharacter;

    // first fram input support
    bool previousFrameChangeCharacterInput = false;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {

        // populate list with characters
        // notice that instead of calling the index in an array,
        // we are instead adding it to the list. (think of a shopping list)
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character0")); 
        // the load looks different! this is because you want a prefab folder inside of your resources folder
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character1"));
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character2"));
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character3"));

        currentCharacter = Instantiate<GameObject>(
            prefabCharacters[0], Vector3.zero,
            Quaternion.identity);
    }
    void Update()
    {
        // ...
        // .... insert other code. Then under "Destroy(currentCharacter);
        // ...

        // instantiate a new random character
        currentCharacter  = Instantiate(
            prefabCharacters[Random.Range(0,4)],
            position, Quaternion.identity);

        // notice theres no change! 
        // that's because lists use the same syntax as arrays when calling for an index.
    }

}


```