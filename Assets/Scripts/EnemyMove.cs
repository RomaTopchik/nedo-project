using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public float startPosition;
    public float endPosition;
    Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement;
        if (!gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            movement = new Vector3(1, 0.0f, 0);
            if (transform.position.x > endPosition)
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            movement = new Vector3(-1, 0.0f, 0);
            if (transform.position.x < startPosition)
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        _rb.velocity = movement * speed;
    }
}
