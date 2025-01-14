using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Vector3 side1 = new Vector3(0, 1, 20);
    Vector3 side2 = new Vector3(20, 1, 0);
    Vector3 side3 = new Vector3(0, 1, -20);
    Vector3 side4 = new Vector3(-20, 1, 0);

    Vector3 direction1 = new Vector3(0, 0, -1);
    Vector3 direction2 = new Vector3(-1, 0, 0);
    Vector3 direction3 = new Vector3(0, 0, 1);
    Vector3 direction4 = new Vector3(1, 0, 0);
    Vector3 direction;

    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (Vector3.Distance(transform.position, side1) < 1.0f) // Threshold for proximity
        {
            direction = direction1;
        }
        else if (Vector3.Distance(transform.position, side2) < 0.1f)
        {
            direction = direction2;
            
        }
        else if (Vector3.Distance(transform.position, side3) < 0.1f)
        {
            direction = direction3;
            
        }
        else if (Vector3.Distance(transform.position, side4) < 0.1f)
        {
            direction = direction4;
            
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (direction == direction1)
        {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);

        }else if (direction == direction2)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        else if (direction == direction3)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (direction == direction4)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

}
