using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 50.0f;
    private float spawnPosZ = 30.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUfo", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.65f, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //spawns a random UFO from array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //spawns UFO
    }
}
