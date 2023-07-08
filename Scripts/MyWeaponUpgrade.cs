using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeaponUpgrade : MonoBehaviour
{
    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<MyWeaponUpgrade>();
        go.GetComponent<MyWeaponSetController>().weaponUpgradeCheck();
    }
}