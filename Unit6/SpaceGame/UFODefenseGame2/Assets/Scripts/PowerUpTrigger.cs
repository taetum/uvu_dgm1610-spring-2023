using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

 public class PowerUpTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject player; 
    public float increasedSpeed;

    public bool isPowerUpActive;
    public float timer;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        isPowerUpActive = false;
    }

    private void Update()
    {
      /*  if (!isPowerUpActive)
        {
            timer = timer + Time.deltaTime;
        }

        if (isPowerUpActive)
        {
            playerMovement.speed = playerMovement.speed += increasedSpeed / 100;
        } */
    }

    [SerializeField] InventoryData InventoryData = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject); //destroy the powerup. this script is on the player, so its destroying the other object.
            InventoryData.UpdatePowerUp(1); // inventory system updates
            Debug.Log(InventoryData.PowerUps + " PowerUps.");

        } 

    }


} 
