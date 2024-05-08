using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //creates a public game object array for animal prefabs
    public GameObject[] animalPrefabs;

    //sets a range and position number for a spawn place
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;

    //sets the start delay and the interval times with a number to decide how quickly animals spawn
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        //invoking repeating so that SpawnRandomAnimals repeatedly gets respawned
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void SpawnRandomAnimal()
    {
        // randomly generates animal index and sends it to random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }


}
