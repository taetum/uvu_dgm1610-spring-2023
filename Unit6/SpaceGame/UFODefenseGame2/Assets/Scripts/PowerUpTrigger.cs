using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

 public class PowerUpTrigger : MonoBehaviour
{

    [SerializeField] InventoryData InventoryData = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            InventoryData.UpdatePowerUp(1);
            Destroy(other.gameObject);
            Debug.Log(InventoryData.PowerUps + " PowerUps.");
        } 

    } 
} 
