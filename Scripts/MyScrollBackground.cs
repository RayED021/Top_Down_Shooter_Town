using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScrollBackground : MonoBehaviour
{
    public Transform[] background;
    public float speed;

    public float topPosY;
    public float bottomPosY;

    void Start()
    {
        
    }

    void Update()
    {
        PositionUpdate();
        CheckPosition();
    }

    private void CheckPosition()
    {
        if(background[0].transform.position.y < bottomPosY)
        {
            background[0].transform.position = new Vector3(0, topPosY, 0);
        }
        if(background[1].transform.position.y < bottomPosY)
        {
            background[1].transform.position = new Vector3(0, topPosY, 0);
        }
    }

    private void PositionUpdate()
    {
        var movement = Time.deltaTime * speed;
        background[0].transform.position = new Vector3(0, background[0].position.y - movement, 0);
        background[1].transform.position = new Vector3(0, background[1].position.y - movement, 0);
    }
}
