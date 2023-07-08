using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAtPlayer : MonoBehaviour
{
    void Update()
    {
        LookAt();
    }

    void LookAt()
    {
        if (MyCode.GameManager.GetInstance().activePlayer != null)
        {
            transform.up = MyCode.GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }

    }
}