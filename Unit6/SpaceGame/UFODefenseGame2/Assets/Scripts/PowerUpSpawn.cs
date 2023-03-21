using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{

    public GameObject PowerUp;
    public float spawnRate = 20;
    public float timer = 0;
    private float spawnRangeX = 50.0f;
    private float spawnPosZ = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else {
            SpawnPowerUp();
            timer = 0;
             }
    }

     void SpawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.65f, spawnPosZ);
        Instantiate(PowerUp, spawnPos, PowerUp.transform.rotation); //spawns UFO
    } 
}
