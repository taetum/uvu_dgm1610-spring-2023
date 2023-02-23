using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public string description;

    public Sprite graphic;

    public int attackDamage;
    public int magicDamage;
    public int attackSpeed;
}
