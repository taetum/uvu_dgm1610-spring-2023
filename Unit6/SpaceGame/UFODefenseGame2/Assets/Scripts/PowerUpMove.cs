using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpMove : MonoBehaviour
{

    public float moveSpeed = 5;
    public GameObject powerUp;


    // Update is called once per frame
    void Update()
    {
        powerUp.transform.position = powerUp.transform.position + (Vector3.back * moveSpeed);

    }


}
