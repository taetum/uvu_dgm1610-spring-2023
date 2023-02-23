using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[CreateAssetMenu]
public class PowerUpData : ScriptableObject
{
    public int moveSpeed;
    public void UpdateValue(int num)
    {
         moveSpeed += num;
    }

}
