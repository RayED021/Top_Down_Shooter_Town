using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MyFireRateModifier : MonoBehaviour
{
    public float modifier = 0.2f;

    private List<MyWeapon> weapons;

    private void Awake()
    {
        weapons = GetComponentsInChildren<MyWeapon>().ToList<MyWeapon>();
    }

    void Start()
    {
        foreach (MyWeapon w in weapons)
        {
            w.addFireRateModifier(modifier);
        }
    }

    private void OnDestroy()
    {
        foreach (MyWeapon w in weapons)
        {
            w.removeFireRateModifier(modifier);
        }
    }

    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<MyFireRateModifier>();
        go.GetComponent<MyWeaponSetController>().weaponUpgradeCheck();
    }
}