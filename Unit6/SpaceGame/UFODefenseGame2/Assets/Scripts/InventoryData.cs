using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "InventoryData")]
public class InventoryData : ScriptableObject
{
    [SerializeField] public int PowerUps = 0;

    public void UpdatePowerUp(int numberofPowerUps) 
    { 
        PowerUps += numberofPowerUps; 
    }

}
