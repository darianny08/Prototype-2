using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    public GameObject[] animalPrefabs;
    private int animalIndex;
    private float spawnRangeX = 85;
    private float spawnPosZ = 90; 
    private float sideSpawnMinZ = -50;
    private float sideSpawnMaxZ = 50;
    private float sideSpawnX = 100;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 1, 1.5f);
        InvokeRepeating("SpawnLeftAnimal", 2, 1.5f);
        InvokeRepeating("SpawnRightAnimal", 3, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SpawnRandomAnimal()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range (0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 100);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    }

    void SpawnLeftAnimal()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range (0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0,90,0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); 
    }




    void SpawnRightAnimal()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range (0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); 
    }
}
