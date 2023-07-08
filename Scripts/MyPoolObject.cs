using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyPoolObjectType 
{
    BULLET, BOLT, EXPLOSION
}

public class MyPoolObject : MonoBehaviour
{
    public MyPoolObjectType type;

    void Start()
    {
        deactivate();
    }
    public void activate(Vector3 position, Quaternion rotation)
    {
        gameObject.SetActive(true);

        transform.position = position;
        transform.rotation = rotation;
    }

    public void deactivate()
    {
        gameObject.SetActive(false);
    }

    internal bool isActive()
    {
        return gameObject.activeInHierarchy;

    }
}