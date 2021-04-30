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

        newScale.x *= 3;

        newScale.y *= 1;

        transform.localScale = newScale;
        
    }
}