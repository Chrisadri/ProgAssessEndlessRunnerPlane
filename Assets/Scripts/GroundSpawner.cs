using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position; //to get the position of the child in GroundTile prefab listed as 1 counting from 0
    }


    // Start is called before the first frame update    
    private void Start()
    {
        for (int i = 0; i < 15; i++) //15 is amount of tiles ahead to spawn
        {
            SpawnTile();
        }
                
    }

   
}
