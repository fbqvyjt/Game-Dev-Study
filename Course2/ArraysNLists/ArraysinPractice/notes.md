# ***Arrays in Practice***

1. Now its time to add an array in our Change Character Exercise
    - At the top of your code in the Character Changer Scripts create an array as such below:

```C#
public class CharacterChanger : MonoBehavior 
{
    [SerializedField]
    GameObject[] prefabCharacters;
}
```

2. Back in the Inspection window of the editor, change the size of the prefab Character to 4 allowing you to populate the elements.

If you go back to the code, there is no indication that our changes exist in the code itself. If you would like to stay consistant, lets create an array object, calling it "new" and dictate how big the array is (in this instance, its 4).

```C#
public class CharacterChanger : MonoBehavior 
{
    [SerializedField]
    GameObject[] prefabCharacters = new GameObject[4];

}
```

3. Now delete the rest of the serialized fields and within the `Start()` method call the index you want to instantiate. To do so you: `NameOfArray[index number]`

```C#
void Start()
{
    currentCharacter = Instantiate<GameObject>(
    prefabCharacters[0], Vector3.zero,
    Quaternion.identity);
}
```

4. Now, the last thing to do is go down to the `Update()` method and remove all of those `else if`s with the array.

```C#

currentCharacter = Instantiate(
    prefabCharacters[Random.Range(0,4)],
    position, Quaternion.identity);

```

5. Alternatively, if you would like to do the same process, minus the inspector/code inconsistency, you can add a resources folder with those prefabs and have it called in the Start method
    - In order to have that code work properly, all that is needed in the code is the GameObject array given a name and number of indicies and then in the start method call the resources folder to identify that prefab. Make sure to typecast each file as a game object, because the Resources.Loads method loads objects not game objects.
    
```C#
public class...
{
    GameObject[] prefabCharacters = new GameObject[4];

    GameObject currentCharacter;

    bool previousFrameChangeCharacterInput = false;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // populate array with characters
        prefabCharacters[0] = (GameObject)Resources.Load("Character0");
        prefabCharacters[1] = (GameObject)Resources.Load("Character1");
        prefabCharacters[2] = (GameObject)Resources.Load("Character2");
        prefabCharacters[3] = (GameObject)Resources.Load("Character3");
    }

}


```