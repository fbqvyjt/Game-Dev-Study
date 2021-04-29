# ***Pushing Buttons... with a Mouse!***
How the character responds from a mouse button by the player

<details>
<summary> Some Definitions and Reminders... </summary>

* ***Prefab*** → a blueprint of a GameObject, or a copy of a GameObject that can be duplicated and put into a scene, event if it didn't exist when the scene was being made; in other words, they can be used to dynamically generate GameObjects.
* ***Instantiate*** → bringing a GameObject into existance. ❤😁
    - Items appear, or "spawn" in the game.
* ***Destroy*** → removing a GameObject out of existance, or Death. ☠🤪
* ***Serialization*** → the automatic process of transforming data structures or object states into a format that Unity can store and reconstruct later. 📫📦

</details>

Lets Make a new script that changes the character
1. First create a new script called "CharacterChanger"
    - Go ahead and attach this to the main camera, not the character.
        - The purpose behind this is so that the the character itself isn't what changes to a new character, its actually more outside influences such as the main character.
    - This script, that's a higher level functionality attached to the main camera, has four different fields that are populated with the prefabs for the four different characters.
        - This is so that I can change to one of those other characters when the time comes.
2. So within this new script, we need four serialized fields to represent the four prefabs of the four characters.
3. Next, we need to keep tracked of what the current character is.
    - When we change characters we are going to replace the initial character with a new one at the same location at once.
4. After that, in the Start() method, put Character0 into the game at the center of the screen so that we start with the character in the game.
5. In the Update() method, let's determine how we can tell if the left, right, or middle mouse button is clicked:
    - In the documentation of Input, we find the `.GetMouseButtonDown(int button)` bool method. It returns true during the from the user pressed the given mouse button.
    - Left Mouse button is: `Input.GetMouseButtonDown(0)`
    - Right Mouse Button is: `Input.GetMouseButtonDown(1)`
    - Middle Mouse Button is: `Input.GetMouseButtonDown(2)`
6. Now that we know the mouse button input methods, let's start to write in the Update method:
    - First, check when the left button is pressed. 
    - Next, save the position of the current character is at, destroy it (`Destroy(currentCharacter)`)
    - Lastly, instantiate (spawn) a new character at that position.
7. Finally, to instantiate the new character, for each of the new character, you are going to have to:
    - First assign a local variable, `int prefabNumber`, that generates a random range of numbers exclusively (that's 0, 1, 2, or 3).
    - Next, check each of those prefabNumbers that are called randomly and set each of those instances to instantiate that character where one was removed. 
8. Once you have saved the file, REMEMBER to remove any character in the scene you have currently before running it becuase our character changer script will create one randomly from the start.
    - Notice that once you have left-clicked several time in the game and after youve used the fourth character, nothing will occur. This is because we randomly chose a number, the same random number might be chosen twice or even more but the other characters have been destroyed.

    
<details>
<summary> The Completed Code of this New Script File </summary>

```C#
sing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCharacter0;
    [SerializeField]
    GameObject prefabCharacter1;
    [SerializeField]
    GameObject prefabCharacter2;
    [SerializeField]
    GameObject prefabCharacter3;

    // need for Location of new character
    GameObject currentCharacter;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(
            prefabCharacter0, Vector3.zero,
            Quaternion.identity);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // change character on Left mouse button
        if (Input.GetMouseButtonDown(0))
        { 
            // save current position and destroy current character
            Vector3 position = currentCharacter.transform.position;
            Destroy(currentCharacter);

            // instantiate a new random character
            int prefabNumber = Random.Range(0, 4);
            if (prefabNumber == 0)
            {
                currentCharacter = Instantiate(prefabCharacter0,
                    position, Quaternion.identity);
            }
            else if (prefabNumber == 1)
            {
                currentCharacter = Instantiate(prefabCharacter1,
                    position, Quaternion.identity);
            }
            else if (prefabNumber == 2)
            {
                currentCharacter = Instantiate(prefabCharacter2,
                    position, Quaternion.identity);
            }
            else
            {
                currentCharacter = Instantiate(prefabCharacter3,
                    position, Quaternion.identity);
            }
        }
    }
}

```
</details>


