using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 100); // Rotation speed in degrees per second
    private bool startRotation = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startRotation = true; // Start rotation
        }
        if (startRotation)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }

    }
}
