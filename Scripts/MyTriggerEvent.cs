using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{

    public UnityEvent OnTrigger;
    public string targetTag;
    public UnityEvent<GameObject> OnTriggerWithGameobject;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == targetTag)
        {
            OnTrigger?.Invoke(); 
            OnTriggerWithGameobject?.Invoke(col.gameObject);
        }
    }
}