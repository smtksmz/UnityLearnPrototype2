using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPerefabs;
    private float spawnrangeX = 20;
    private float spawnrangeZ = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPerefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnrangeX, spawnrangeX), 0, spawnrangeZ);
        Instantiate(AnimalPerefabs[animalIndex], spawnPos, AnimalPerefabs[animalIndex].transform.rotation);
    }
}
