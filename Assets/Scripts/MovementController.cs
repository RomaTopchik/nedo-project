using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private bool isGrounded;
    public float speed = 10f;
    public float jumpForce = 10f;

    [SerializeField]
    private PlayerPhysics playerPhysics;

    // Start is called before the first frame update
    void Start()
    {
        playerPhysics.CollisionEnterEvent += CollisionEnter;
        playerPhysics.CollisionExitEvent += CollisionExit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInputData(InputData inputData)
    {
        rb.velocity = inputData.moveVector;
        
        if(inputData.isJump)
        {
            TryJump();
        }

    }


    void TryJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }
    }


    void CollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void CollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            isGrounded = value;
        }
    }



}
