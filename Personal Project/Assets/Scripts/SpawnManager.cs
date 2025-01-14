using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] cubePrefabs; // Array of cube prefabs
    private Vector3[] sidePositions; // Array of side positions

    private Vector3 side1 = new Vector3(0, 1, 20);
    private Vector3 side2 = new Vector3(20, 1, 0);
    private Vector3 side3 = new Vector3(0, 1, -20);
    private Vector3 side4 = new Vector3(-20, 1, 0);

    private float startDelay = 3.0f;
    private float spawnInterval;

    void Start()
    {
        // Define the positions of the plane's sides
        sidePositions = new Vector3[] { side1, side2, side3, side4 };

        spawnInterval = Random.Range(2.0f, 5.0f);
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }

    void SpawnRandomCube()
    {
        // Generate a random index for the side and cube type
        int positionIndex = Random.Range(0, sidePositions.Length);
        int typeIndex = Random.Range(0, cubePrefabs.Length);

        // Spawn the cube at the selected side position
        Instantiate(cubePrefabs[typeIndex], sidePositions[positionIndex], cubePrefabs[typeIndex].transform.rotation);

        
    }
}
