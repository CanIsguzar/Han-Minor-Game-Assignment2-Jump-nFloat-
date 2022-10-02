using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public int maxBulletCount = 3;

    void Update()
    {
        if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (transform.childCount <= maxBulletCount)
                {
                    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.transform.parent = transform;
                    bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
                }
            }
        }
    }
}

