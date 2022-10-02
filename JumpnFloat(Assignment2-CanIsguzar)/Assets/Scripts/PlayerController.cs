using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    public float jumpForce = 0;
    public float rotationSpeed;
    private float movementX;
    private float movementY;
    public Vector2 move;
    public float senseX = 5f;
    public Vector2 lookVal;
    private bool isGrounded;




    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        transform.Rotate(0, lookVal.x * senseX, 0);


    }

    void OnLook(InputValue lookValue)
    {
        lookVal = lookValue.Get<Vector2>();


    }

    void OnMove(InputValue movementValue)
    {
        move = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {

        Vector3 movement = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * new Vector3(move.x, 0.0f, move.y);

        rb.MovePosition(transform.position + movement * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Physics.gravity = new Vector3(0, 0, 0);
            StartCoroutine(ResetGravity());

        }
    }

    IEnumerator ResetGravity()
    {
        yield return new WaitForSeconds(3);
        Physics.gravity = new Vector3(0, -9.81f, 0);
    }
}

