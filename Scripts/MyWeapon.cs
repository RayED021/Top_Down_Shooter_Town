using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public float fireRate;
    public MyPoolObjectType type;
    private float timer = 0;

    public List<float> fireRateModifiers;

    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    public void Shoot()
    {
        if (timer == 0f)
        {
            MyObjectPool.GetInstance().requestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate / getFireRateModifier();
        }
    }

    private float getFireRateModifier()
    {
        float mod = 1;
        foreach (float f in fireRateModifiers)
        {
            mod += f;
        }

        return mod;
    }


    internal void addFireRateModifier(float modifier)
    {
        fireRateModifiers.Add(modifier);
    }


    internal void clearModifier()
    {
        fireRateModifiers.Clear();
    }

    internal void removeFireRateModifier(float modifier)
    {
        fireRateModifiers.Remove(modifier);
    }

}