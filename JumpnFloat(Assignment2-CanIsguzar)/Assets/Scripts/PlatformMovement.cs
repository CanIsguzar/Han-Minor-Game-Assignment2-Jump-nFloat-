using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private float positionX;
    private float speed = 1f;

    //object loops between the y positions of -0.86 and 9
    void Update()
    {
        positionX = transform.position.x;
        if (positionX < 6)
        {
            speed = 2f;
        }
        if (positionX > 13)
        {
            speed = -2f;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }


}
