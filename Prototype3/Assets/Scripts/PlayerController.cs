using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10.0f;
    public float gravityModifier = 1.0f;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;

    //GameObject PlayerController collider;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        playerAnim = GetComponent<Animator>();


        // SET POSITION of the player touching to ground
        GameObject player = GameObject.Find("Player");

        BoxCollider collider = GameObject.Find("Player").GetComponent<BoxCollider>();
        GameObject ground = GameObject.Find("Ground");

        Vector3 newPosition = ground.transform.position;
        collider.transform.position = new Vector3(collider.transform.position.x,
            newPosition.y, collider.transform.position.z); 


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ) && isOnGround)
        {
            //ForceMode.Impulse: immediately applies the force
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game OVER");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int", 1);

           
        }
        
    }
}
