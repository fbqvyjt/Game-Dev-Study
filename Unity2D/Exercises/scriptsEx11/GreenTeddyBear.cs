using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTeddyBear : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // quadruple width and height

        Vector3 newScale = transform.localScale;

        newScale.x *= 1;

        newScale.y *= 3;

        transform.localScale = newScale;
        
    }
}