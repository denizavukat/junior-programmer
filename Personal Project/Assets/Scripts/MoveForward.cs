using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10.0f;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        // Choose a random side to spawn
        int randomSide = Random.Range(1, 5); // 1 to 4 (inclusive)

        switch (randomSide)
        {
            case 1: // Top side (side1)
                transform.position = new Vector3(Random.Range(-20f, 20f), 1, 20f);
                direction = new Vector3(0, 0, -1); // Move downward
                break;

            case 2: // Right side (side2)
                transform.position = new Vector3(20f, 1, Random.Range(-20f, 20f));
                direction = new Vector3(-1, 0, 0); // Move left
                break;

            case 3: // Bottom side (side3)
                transform.position = new Vector3(Random.Range(-20f, 20f), 1, -20f);
                direction = new Vector3(0, 0, 1); // Move upward
                break;

            case 4: // Left side (side4)
                transform.position = new Vector3(-20f, 1, Random.Range(-20f, 20f));
                direction = new Vector3(1, 0, 0); // Move right
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move in the chosen direction
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
