using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rb;
    public float speed = 10f;
    public float jumpForce = 10f;

    public bool _isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        MovementLogic();
        JumpLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0);
       

        //_rb.AddForce(movement * speed);

        _rb.velocity = movement * speed;
        if (moveHorizontal < 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        if (moveHorizontal > 0)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;


    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded)
            {
                //_rb.AddForce(Vector3.up * jumpForce);

                _rb.velocity = Vector3.up * jumpForce;

            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}
