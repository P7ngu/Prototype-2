using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) //"S" is pressed down
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                0, spawnPosZ);

            animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex],
                spawnPosition,
                animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
