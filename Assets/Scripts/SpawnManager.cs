using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 20;
    private float spawnRangeZ = 30;

    // set start delay on the class beginning method routine to spawn animals and the rate of spawn
    private float startDelay = 2;
    private float spawnInterval;


    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3, 5);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnRangeZ);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }  
        */ 
    }
}
