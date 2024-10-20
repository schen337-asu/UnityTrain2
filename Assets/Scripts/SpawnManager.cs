using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnPosX = 20;
    private float spawnRangeZ = 30;
    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int SpawnRandomAnimal()
    {
        return Random.Range(0, animalPrefabs.Length);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnRangeZ);
            animalIndex = SpawnRandomAnimal();
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }   
    }
}
