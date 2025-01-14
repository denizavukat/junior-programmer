using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xLimit = 20.0f;

    private float zLimit = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the object is out of bounds on the X-axis
        if (transform.position.x < -xLimit || transform.position.x > xLimit)
        {
            Debug.Log($"Object destroyed for exceeding X bounds: {transform.position.x}");
            Destroy(gameObject);
        }

        // Check if the object is out of bounds on the Z-axis
        if (transform.position.z < -zLimit || transform.position.z > zLimit)
        {
            Debug.Log($"Object destroyed for exceeding Z bounds: {transform.position.z}");
            Destroy(gameObject);
        }
    }
}
