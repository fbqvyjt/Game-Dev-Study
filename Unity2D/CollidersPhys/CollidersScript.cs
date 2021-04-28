using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityBoi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        const float MinImpulseForce = 3F;
        const float MaxImpulseForce = 5F;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    /// <summary>
    /// Called on a collision
    /// </summary>
    /// <param name="collision">collision info</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ouch");

    }
}