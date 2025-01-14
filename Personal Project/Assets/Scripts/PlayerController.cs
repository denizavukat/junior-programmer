using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f; 
    public float jumpForce = 50f; 
    public LayerMask groundLayer; // Layer that represents the ground

    private Rigidbody rb; // Reference to the Rigidbody
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.0f, groundLayer);


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Left/Right
        float verticalInput = Input.GetAxis("Vertical"); // Forward/Backward

        Vector3 movement = new Vector3(-1*horizontalInput, 0, -1*verticalInput) * moveSpeed;

        rb.AddForce(movement);

        if (movement.magnitude > 0.01f) // Ensure there's enough movement to rotate
        {
            RotateBall(movement);
        }
        
    }

    void RotateBall(Vector3 movement)
    {
        // Calculate the rotation direction for the ball
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, movement.normalized);

        rb.AddTorque(rotationAxis * moveSpeed);
    }

}
