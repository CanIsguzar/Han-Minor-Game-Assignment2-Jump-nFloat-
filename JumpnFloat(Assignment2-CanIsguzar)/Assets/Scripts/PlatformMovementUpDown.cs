using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementUpDown : MonoBehaviour
{

    private float positionY;
    private float speed = 2f;

    //object loops between the y positions of -0.86 and 9
    void Update()
    {
        positionY = transform.position.y;
        if (positionY < -0.86)
        {
            speed = 2f;
        }
        if (positionY > 9)
        {
            speed = -2f;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
