using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Jump : MonoBehaviour
{
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
    }

    void OnJump(InputValue value)
    {
        if (isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
