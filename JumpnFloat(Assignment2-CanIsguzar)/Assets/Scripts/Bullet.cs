using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<EnemyHealth>().Health -= 1;
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = collision.transform.position - transform.position;
                direction.y = 0;
                rb.AddForce(direction.normalized * 5, ForceMode.Impulse);
            }
        }
    }
}
