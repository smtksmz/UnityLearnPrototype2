using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 50.0f;
    private float LowerBound = -10.0f;
    public static int animalsCounter = 0;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBound)
        {
            Destroy(gameObject);
            animalsCounter++;    
        }
    }
}
