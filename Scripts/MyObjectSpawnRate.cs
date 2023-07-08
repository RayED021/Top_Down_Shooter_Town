using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MyObjectSpawnRate
{
    [Range(1, 100)] public int rate;
    public GameObject prefab;
}
