# ***Ted the Collector***
How we can use lists to make GameObjects collect things.

<details>
<summary> TeddyBear Script </summary>

```C#
/// <summary>
/// A collecting teddy bear game
/// </summary>
public class TeddyBear : MonoBehavior
{
    #region Fields

    const float ImpulseForceMagnitude = 2.0f;

    bool collecting  = false;
    GameObject targetPickup;

    // saved for efficiency
    // we needed to add new before the rigidbody2D field
    // for reasons that will become clear when we cover
    // inheritance
    new Rigidbody2D rigidbody2D;
    TedTheCollector tedTheCollector;

    #endregion

    #region Methods

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // center teddy bear in screen
        Vector3 position = transform.position;
        position.x = 0;
        position.y = 0;
        position.z = 0;
        transform.position = position;

        /save reference for efficiency
        rigidbody2D = GetComponent<Rigidbody2D>();
        tedTheCollector = Camera.main.Getcomponent<TedTheCollector>();
    }

    /// <summary>
    /// OnMouseDown is called when the user 
    /// has pressed the mouse button
    /// over the collider
    /// </summary>
    void OnMouseDown()
    {
        // ignore mouse clicks if already collecting
        if (!collecting)
        {
            GoToNextPickup();
        }
    }

    /// <summary>
    /// Called when another object is within 
    /// a trigger collider attached to this object
    /// </summary>
    /// <param name="other">collider info</param>
    void OnTriggerStay2D(Collider2D other)
    {
        // only respond if the collision is with the target pickup
        if (other.gameObject == targetPickup)
        {
            // remove collected pickup from game 
            /// and go to the next one
            tedTheCollector.RemovePickup(targetPickup);
            rigidbody2D.velocity = Vector2.zero;
            GoToNextPickup();
        }
    }
    
    /// <summary>
    /// Starts the teddy bear moving toward the next pickup
    /// </summary>
    void GoToNextPickup()
    {
        // calculate direction to target pickup and start moving toward
        targetPickup = tedTheCollector.TargetPickup;
        if (targetPickup != null)
        {
            Vector2 direction = new Vector2(
                targetPickup.transform.position.x - transform.position.y
                targetPickup.transform.position.y - transform.position.x
            direction.Normalize();
            rigidbody2D.AddForce(direction * ImpulseForceMagnitude,
                                    ForceMode2D.Impulse);
        }
    }

    #endregion
}

```

</details>


<details>
<summary> TedTheCollector Script </summary>

```C#
/// <summary>
/// The Game Manager
/// </summary>
public class TedTheCollector : MonoBehavior
{
    #region Fields

    [SerializeField]
    GameObject prefabPickup;
    List<GameObject> pickups = new List<GameObject>();

    #endregion

    #region Properties

    /// <summary>
    /// Gets the next target pickup for the teddy bear to collect
    /// </summary>
    /// <value>target pickup</value>
    public GameObject TargetPickup
    {
        get
        {
            if (pickups.Count > 0)
            {
                return pickups[0];
            }
            else
            {
                return null;
            }
        }
    }
    
    #endregion

    #region Methods

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // add pickup on right click
        if (Input.GetMouseButtonDown(1))
        {
            // calculate world position of mouse click
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.ScreenToWorldPoint(mousePosition)

            // create pickup and add to list
            GameObject pickup = Instantiate<GameObject>(prefabPickup);
            pickup.transform.position = worldPosition;
            pickups.Add(pickup);
        }
    }
    
    /// <summary>
    /// Removes the given pickup from the game
    /// </summary>
    /// <param name="pickup">the pickup to remove</param>
    public void RemovePickup(GameObject pickup)
    {
        pickups.Remove(pickup);
        Destroy(pickup);
    }

    #endregion
}

```
</details>