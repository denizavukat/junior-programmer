using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Vector3 side1 = new Vector3(0, 1, 20);
    Vector3 side2 = new Vector3(20, 1, 0);
    Vector3 side3 = new Vector3(0, 1, -20);
    Vector3 side4 = new Vector3(-20, 1, 0);

    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, side1) < 1.0f) // Threshold for proximity
        {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, side2) < 0.1f)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, side3) < 0.1f)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, side4) < 0.1f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

}
