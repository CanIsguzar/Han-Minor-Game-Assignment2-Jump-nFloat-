using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Will run after all the other updates are runned (heb je zekerheid dat het als laatste gecalt word na alle andere updates)
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        GetComponent<Camera>().transform.rotation = player.transform.rotation;
    }
}
