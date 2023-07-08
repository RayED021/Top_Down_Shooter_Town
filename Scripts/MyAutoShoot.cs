using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyAutoShoot : MonoBehaviour
{

    void Update()
    {
        foreach (MyWeapon w in GetComponentsInChildren<MyWeapon>())
        {
            w.Shoot();
        }
    }
}

