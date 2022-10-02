using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter()
    {

        Debug.Log("collision detected!");
        Destroy(gameObject);

    }
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}