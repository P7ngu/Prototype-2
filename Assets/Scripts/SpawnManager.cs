using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float spawnRangeX = 20;
    public float spawnRangeZ = 15;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //TIMER
    }

    // Update is called once per frame
    void Update()
    {
  
        
    }

    void SpawnRandomAnimal()
    {
        float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        float spawnPointX = Random.Range(-spawnRangeX, spawnRangeX);

        Vector3 spawnPosition = new Vector3(
                 spawnPointX,
                0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
            spawnPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
