using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay * Random.Range(3, 9), spawnInterval * Random.Range(3, 9));
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay * Random.Range(3, 9), spawnInterval * Random.Range(3, 9));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosTop, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(0, 16));
        Quaternion target = Quaternion.Euler(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, target);
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(0, 16));
        Quaternion target = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPosLeft, target);
    }
}
