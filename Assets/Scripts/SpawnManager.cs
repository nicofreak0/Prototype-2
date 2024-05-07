using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //creates a public game object array for animal prefabs
    public GameObject[] animalPrefabs;

    //sets a range and position number for a spawn place
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // creates an if statement so that when S is pushed it generates an animal prefab in the game scene
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            // randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            
        }
        
    }
}
