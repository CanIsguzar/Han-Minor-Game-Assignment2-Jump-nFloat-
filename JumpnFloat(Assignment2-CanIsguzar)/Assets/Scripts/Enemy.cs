using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public float moveSpeed;
    public GameObject target;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.transform.position - transform.position;
            direction.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            if (direction.magnitude > 2)
            {
                transform.Translate(0, 0, moveSpeed * Time.deltaTime);
            }
        }
        else
        {
            target = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.Translate(0, 0, 0);
            StartCoroutine(StopEnemy());
        }

    }

    IEnumerator StopEnemy()
    {
        yield return new WaitForSeconds(3);
    }


}

