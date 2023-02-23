using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplay : MonoBehaviour
{
    public Weapon Weapon;
    public Text weaponName;
    public Text weaponDescription;
    public Image weaponSprite;
    public Text attackDamageText;
    public Text magicDamageText;
    public Text attackSpeedText;

    // Start is called before the first frame update
    void Start()
    {
        weaponName.text = Weapon.weaponName;
        weaponDescription.text = Weapon.description;
        weaponSprite.sprite = Weapon.graphic;
        attackDamageText.text = Weapon.attackDamage.ToString();
        magicDamageText.text = Weapon.magicDamage.ToString();
        attackSpeedText.text = Weapon.attackSpeed.ToString();
    }

}
