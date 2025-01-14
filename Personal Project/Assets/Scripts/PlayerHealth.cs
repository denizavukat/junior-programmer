using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHearts = 5; 
    private int currentHearts; 

    void Start()
    {
        currentHearts = maxHearts;
        UpdateUI();
    }

    void UpdateUI()
    {
        Debug.Log($"Current Hearts: {currentHearts}");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            DecreaseHealth();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("HealthCapsule"))
        {
            IncreaseHealth();
            Destroy(other.gameObject); 
        }
    }

    void DecreaseHealth()
    {
        currentHearts--;
        UpdateUI();

        if (currentHearts <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

    void IncreaseHealth()
    {
        if (currentHearts < maxHearts)
        {
            currentHearts++;
            UpdateUI();
        }
    }
}
