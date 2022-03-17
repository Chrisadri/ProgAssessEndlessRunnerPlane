using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2); //destroys the game object (ground tile) 2 seconds after leaving it 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        //choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(2, 8); // we put this to geta  random number between these child objects in floor tiles, it excludes the last number in unity meanning it's onlt 2-4 counting from 0
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //spawn obstacle at that position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

    }

}
