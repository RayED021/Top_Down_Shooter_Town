using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyPlayerController : MonoBehaviour
{
    public MyInputHandler myInputHandler;
    private MyMoveable moveable;

    void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    private void OnSetDirect(Vector2 direction)
    {
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        myInputHandler.OnSetDirectionAction += OnSetDirect;
    }

    private void OnDisable()
    {
        myInputHandler.OnSetDirectionAction -= OnSetDirect;
    }
    void Update()
    {

    }
}