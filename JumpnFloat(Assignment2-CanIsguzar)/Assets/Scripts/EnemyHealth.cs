using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 3;
    [SerializeField] private float KnockbackStrength;

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health -= 1;
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = collision.transform.position - transform.position;
                direction.y = 0;
                rb.AddForce(direction.normalized * KnockbackStrength, ForceMode.Impulse);

            }

        }
    }

}

