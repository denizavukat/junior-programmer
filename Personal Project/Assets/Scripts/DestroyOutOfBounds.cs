using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xLimit = 20.0f;

    private float zLimit = 20.0f;
    float clampedX;
    float clampedZ;
    // Start is called before the first frame update
    void Start()
    {
        clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        clampedZ = Mathf.Clamp(transform.position.z, -zLimit, zLimit);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xLimit || transform.position.x > xLimit || transform.position.z < -zLimit || transform.position.z > zLimit)
        {
            if (gameObject.CompareTag("PlayerBall"))
            {
                // Calculate the clamped X and Z positions
                float clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
                float clampedZ = Mathf.Clamp(transform.position.z, -zLimit, zLimit);

                // Update the position to stay within bounds
                transform.position = new Vector3(clampedX, transform.position.y, clampedZ);

                //Debug.Log($"PlayerBall clamped to position: {transform.position}");
            }
            else
            {
                //Debug.Log($"Object destroyed for exceeding bounds: {transform.position}");
                Destroy(gameObject);
            }
        }
    }
}
