# ***Unity Input Practice***

<details>
<summary> Mouse Jumping </summary>
Tasks:

* Create a project and add a sprite
* Write a new script to make the sprite jump. Remove the `Start()` Method and write everything in the `Update()` Method
* Make sure it works properly by attaching the script.

```C#
void Update()
{
    if (Input.GetMouseButtonDowwn(0))
    {
        // calculate mouse world position
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camer.main.ScreenToWorldPoint(mousePosition);

        // move sprite to mouse location
        transform.position = worldPosition;
    }
}
```

</details>
<br></br>

<details>
<summary> Spawn and Explode </summary>
Tasks:

* Download needed materials for project.
* Setup the mouse button processor.
* Spawn teddy bear on left mouse button.
* Explode a teddy Bear on right mouse button.

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

                GameObject.Instantiate(prefabTeddyBear, mousePosition, Quaternion.identity);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;

                GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
                if (teddyBear != null)
                {
                    Instantiate(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
	}
}

```

</details>
<br></br>

<details>
<summary> Finally, a Driving Game </summary>

* 
* 
* 
* 

</details>
