using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class TurretBlueprint
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradePrefab;
    public int upgradeCost;

    public int GetCostAmount()
    {
         return cost / 2;
    
    }

    public int GetCostAmountUpgraded()
    {
        return (cost+upgradeCost) / 2;

    }

}
